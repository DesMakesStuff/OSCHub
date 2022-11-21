using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bespoke.Common;
using Bespoke.Common.Net;
using Bespoke.Osc;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.InteropServices;
namespace OSCHub
{
    
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
        
        public static void StartThreadedServer(int Port)
        {
            //Receive a call to start a server on a new thread with specified port
            Thread OSCThread = new Thread(Program.serverMethod);
            OSCThread.Start(Port);
        }

         private static void oscServer_MessageReceived(object sender, OscMessageReceivedEventArgs e)
         {
            sMessagesReceivedCount++;

            OscMessage message = e.Message;

            Console.WriteLine(string.Format("\nMessage Received [{0}]: {1}", message.SourceEndPoint.Address, message.Address));
            Console.WriteLine(string.Format("Message contains {0} objects.", message.Data.Count));

            for (int i = 0; i < message.Data.Count; i++)
            {
            string dataString;

            if (message.Data[i] == null)
            {
               dataString = "Nil";
            }
            else
            {
             dataString = (message.Data[i] is byte[]? BitConverter.ToString((byte[])message.Data[i]) : message.Data[i].ToString());
            }
             Console.WriteLine(string.Format("[{0}]: {1}", i, dataString));
             
             IPEndPoint srcEP = new IPEndPoint(IPAddress.Loopback.Address, 9000);
             
             
             
            }

            Console.WriteLine("Total Messages Received: {0}", sMessagesReceivedCount);
            }

            private static void oscServer_ReceiveErrored(object sender, ExceptionEventArgs e)
            {
                Console.WriteLine("Error during reception of packet: {0}", e.Exception.Message);
            }


        public static void serverMethod(object Port)
        {
            OscServer oscServer;
            oscServer = new OscServer(Bespoke.Common.Net.TransportType.Udp, System.Net.IPAddress.Loopback, (int)Port);

            oscServer.FilterRegisteredMethods = false;
            oscServer.RegisterMethod(AvatarParams);

            oscServer.MessageReceived += new EventHandler<OscMessageReceivedEventArgs>(oscServer_MessageReceived);
            oscServer.ReceiveErrored += new EventHandler<ExceptionEventArgs>(oscServer_ReceiveErrored);
            oscServer.ConsumeParsingExceptions = false;
            oscServer.Start();
           
            Console.ReadKey();
            
        }
        
      
        
        private static readonly string AvatarParams = "/avatar/parameters";
        

        
        private static int sMessagesReceivedCount;

        
     }


    public static class Transmitter
    {
        public static void Start(OscPacket packet,int port)
        {
            IPEndPoint Destination = new IPEndPoint(IPAddress.Loopback.Address, port);
            Assert.ParamIsNotNull(packet);

            mOscClient = new OscClient(Destination);
            mOscClient.Connect();
            packet.Client = mOscClient;

            mCancellationTokenSource = new CancellationTokenSource();
            mSendPacketsTask = Task.Run(() => SendPacketsAsync(packet, mCancellationTokenSource.Token));
        }

        public static void Stop()
        {
            mCancellationTokenSource.Cancel();
            mSendPacketsTask.Wait();
            mOscClient.Close();
        }

        public static void Dispose()
        {
            mCancellationTokenSource.Dispose();
        }

        public static async Task SendPacketsAsync(OscPacket packet, CancellationToken cancellationToken)
        {
            try
            {
                int transmissionCount = 0;

                while (cancellationToken.IsCancellationRequested == false)
                {
                    packet.Send();

                    Console.Clear();
                    Console.WriteLine("Osc Transmitter: Tcp");
                    Console.WriteLine("Transmission Count: {0}\n", ++transmissionCount);
                    Console.WriteLine("Press any key to exit.");

                    await Task.Delay(1000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        

        public static CancellationTokenSource mCancellationTokenSource;
        public static Task mSendPacketsTask;
        public static OscClient mOscClient;
    }
}


