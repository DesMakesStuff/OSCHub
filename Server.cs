using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using OSCHub;
using SharpOSC;
public class Server
{
	public static TcpListener server = new TcpListener(IPAddress.Any, 9001);
	public static TcpClient MainListenClient;
	public static bool ShutServer = false;
	public static UDPListener listener;
	public Server()
	{

	}

	public static void EntryServer()
	{



	}

	public static void TearDownServer()
	{

		try
		{
			Form1.ct.Cancel();
			Console.WriteLine("Cancelling Thread");

			//Form1.serverThread.Join();
		}
		catch (PlatformNotSupportedException e)
		{
			Console.WriteLine("PlatformException: {0}", e);
		}
		catch (ArgumentNullException e)
		{
			Console.WriteLine("No Connections Terminated: {0}", e);
		}
	}

	public static void SendMessageToApps(OscMessage message)
	{
			
			//var sender = new SharpOSC.UDPSender("127.0.0.1", 9000);
			foreach(AppObject App in Form1.AppsObjectList)
            {
				var sender = new SharpOSC.UDPSender(App.IP, Int32.Parse(App.Port));
				
				try
				{
					sender.Send(message);
				}
				catch (NullReferenceException e)
				{
					Console.WriteLine("Null value skip");
				}
			}
				
	}
	public static void StartServer(object obj)
	{
		// The cabllback function
		HandleOscPacket callback = delegate (OscPacket packet)
		{
			var messageReceived = (OscMessage)packet;

			
			try
			{
				Console.WriteLine("Received a message!"+ messageReceived.Address);
				Console.WriteLine("Received a message!"+ messageReceived.Arguments[0]);
			}
			catch (NullReferenceException e)
            {
				Console.WriteLine("Null");
            }
		
			SendMessageToApps(messageReceived);

		};

		listener = new UDPListener(9001, callback);
		Console.WriteLine("Server started!");
		
	}
}
