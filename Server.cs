using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows;
using System.Text;
using OSCHub;
using SharpOSC;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
public class Server
{
    public static TcpListener server = new TcpListener(IPAddress.Any, 9001);
    public static TcpClient MainListenClient;
    public static bool ShutServer = false;
    public static UDPListener listener;
    public delegate void UpdateAvatar(String ID);
    public static Control control;
    public static string avi_ID;
    public static OscMessage previousPacket;
    // Events
    public delegate void UIUpdateEventHandler(string arg1, string arg2);
    public static event UIUpdateEventHandler IDUpdated;
    public Server() { }


    

    public static void SendMessageToApps(OscMessage message)
    {
        foreach (AppObject App in Form1.AppsObjectList)
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
        HandleOscPacket callback = delegate (OscPacket packet) {
            var messageReceived = (OscMessage)packet;

            try
            {
                Console.WriteLine("Received a message!" + messageReceived.Address + "" +
                                  messageReceived.Arguments[0]);

            

                if (messageReceived.Address == "/avatar/change")
                {
                    avi_ID = messageReceived.Arguments[0].ToString();
                    Console.WriteLine("New Avatar ID: " + messageReceived.Arguments[0]);
                    previousPacket = messageReceived;
                    OnUpdateID("av_id",avi_ID);
                }
                //IF debugging begin checking and adding to list
                if (Form1.isdebug == true)
                {
                    bool isfound = false;
                    //Loop through the list of objects updating parameters
                   for(int i=0;i<Form1.parameter_list.Count;i++)
                    {
                        if(messageReceived.Address == Form1.parameter_list[i].Address)
                        {
                            Form1.parameter_list[i].Arguments[0] = messageReceived.Arguments[0];
                           

                            isfound = true;
                        }
                       
                    }
                   //Didn't find any case of address in the list
                    if (isfound == false)
                    {
                        Form1.parameter_list.Add(messageReceived);
                        Form1.ParamList.Add(messageReceived.Address);
                      
                        
                        
                    }

                }

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

    public static void OnUpdateID(string op,string ID)
    {
        if (IDUpdated != null) IDUpdated(op,ID);
    }
}
