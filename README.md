# 5G for Industrial Internet of Things

The future of industrial production lies in Industry 4.0, the intelligent factory, and the Industrial Internet of Things (IIoT). A suitable framework for communication and thorough connectivity is needed to increase the flexibility, autonomy, and efficiency of production facilities and intralogistics. The development of the 5G communication standard offers significant new perspectives.

In this project, we use 5G for communicating between a server and a client. In this architecture, we use a single 5G modem on either side i.e., Server and client for communication. Since there is no redundancy in communication, the system is prone to failure. The current 5G modem does not offer redundant channels. we must employ new ways to use redundancy. In the proposed method we use two 5G modems and by connecting them to the system using a virtual bonding technique we can achieve redundancy. 

The Scope of this Project is to build and analyze the OPC-UA communication with redundant 5G connection for Industrial use cases. To achieve this, we used C# programming to develop a client and Server on Raspberry PI. C# is selected for its performance and memory management which is very important for IoT applications. Redundancy in the 5G communication is achieved by using two 5G modems on each side i.e., server and client.


The main focus of this project  is divided into the following parts 
1) To monitor and control systems over a 5G network using the OPC UA protocol
2) Testing the latency over a long range.
3) PoC for the dual channel in a 5G modem for redundancy in the network.


