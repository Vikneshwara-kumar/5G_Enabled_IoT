using System;
using System.Threading;

using Opc.UaFx.Client;

public class Program
{
    public static void Main()
    {
        using (var client = new OpcClient("opc.tcp://169.254.8.230:48430"))
        {
            Console.WriteLine("Connecting to server");
            client.Connect();
            Console.WriteLine("Connection Established");

            while (true)
            {
                var temperature = client.ReadNode("ns=2;s=Temperature");
                var flow = client.ReadNode("ns=2;s=Flow");
                Console.WriteLine("Current Temperature is {0} °C", temperature);
                Console.WriteLine("Current Flow Rate is {0} M3/H", flow);

                //var results = client.WriteNode("ns=3;s= Status", 10.0);

                Thread.Sleep(1000);
            }
        }
    }
}