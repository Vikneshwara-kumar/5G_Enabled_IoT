using System.Threading;
using System;
using Opc.UaFx;
using Opc.UaFx.Server;

class Program
{
    public static void Main()
    {
        // Input and output definations
        var IOnode1 = new OpcFolderNode("Device1");
        var In1 = new OpcDataVariableNode<bool>(IOnode1, "ExitSensor-IPA");
        var In2 = new OpcDataVariableNode<int>(IOnode1, "Vision-IPA");
        var Op1 = new OpcDataVariableNode<bool>(IOnode1, "Convy1-IPA");
        var Op2 = new OpcDataVariableNode<bool>(IOnode1, "Convy2-IPA");
        var Op31 = new OpcDataVariableNode<bool>(IOnode1, "sorter1Turn-IPA");
        var Op32 = new OpcDataVariableNode<bool>(IOnode1, "sorter1Belt-IPA");
        var Op41 = new OpcDataVariableNode<bool>(IOnode1, "sorter2Turn-IPA");
        var Op42 = new OpcDataVariableNode<bool>(IOnode1, "sorter2Belt-IPA");
        var Op51 = new OpcDataVariableNode<bool>(IOnode1, "sorter3Turn-IPA");
        var Op52 = new OpcDataVariableNode<bool>(IOnode1, "sorter3Belt-IPA");
        var Op61 = new OpcDataVariableNode<int>(IOnode1, "Counter1-IPA");
        var Op62 = new OpcDataVariableNode<int>(IOnode1, "Counter2-IPA");
        var Op63 = new OpcDataVariableNode<int>(IOnode1, "Counter3-IPA");

        int buf1, buf2, buf3;
        bool a;

        using (var server = new OpcServer("opc.tcp://192.168.241.102:4804", IOnode1)) // Server IP defination

        {
            buf1 = 0;
            buf2 = 0;
            buf3 = 0;

            Console.WriteLine("Hosting Server");
            server.Start(); // hosting the Server 
            Console.WriteLine("Hosting Server completed");
            Console.WriteLine("Server is online");

            Op2.Value = true; 
            Op1.Value = true;

            while (true)                        //loop will start once the server is started
            {
                int Visionsensor = In2.Value;
                Console.WriteLine(Visionsensor.ToString());
                switch (Visionsensor)
                {
                    case 1:                     // case operation for first arm of sorter
                        buf1 = buf1 + 1;        // count for Counter-1
                        Op61.Value = buf1;
                        Op32.Value = true;
                        Op31.Value = true;
                        Thread.Sleep(3000);
                        Op1.Value = false;
                        Thread.Sleep(2000);     //Depending on the process dealy is given for convyor-1 
                        Op31.Value = false;
                        Op32.Value = false;
                        Op1.Value = true;
                        break;

                case 4:                         // case operation for first arm of sorter
                        buf2 = buf2 + 1;        // count for Counter-2
                        Op62.Value = buf2;
                        Op42.Value = true;
                        Op41.Value = true;
                        Thread.Sleep(3000);
                        Op1.Value = false;
                        Thread.Sleep(6000);     //Depending on the process dealy is given for convyor-1 
                        Op41.Value = false;
                        Op42.Value = false;
                        Op1.Value = true;
                        break;

                 case 7:                        // case operation for first arm of sorter
                        buf3 = buf3 + 1;        // count for Counter-3  
                        Op63.Value = buf3;
                        Op52.Value = true;
                        Op51.Value = true;
                        Thread.Sleep(3000);
                        Op1.Value = false;
                        Thread.Sleep(10000);    //Depending on the process dealy is given for convyor-1 
                        Op51.Value = false;
                        Op1.Value = true;
                        break;       
                }
             IOnode1.ApplyChanges(server.SystemContext);
            }
        }
    }
}



