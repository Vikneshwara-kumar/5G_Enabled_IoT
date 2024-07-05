# **5G for Industrial Internet of Things (IIoT)**

## Project Overview
The future of industrial production lies in Industry 4.0, the intelligent factory, and the Industrial Internet of Things (IIoT). To enhance the flexibility, autonomy, and efficiency of production facilities and intralogistics, a robust framework for communication and thorough connectivity is essential. The development of the 5G communication standard offers significant new perspectives in this domain.

This project leverages 5G technology to establish communication between a server and a client. In this architecture, a single 5G modem is used on either side (Server and Client) for communication. However, the absence of redundancy in this setup makes the system prone to failure. Current 5G modems do not offer redundant channels, necessitating innovative methods to implement redundancy. Our proposed method employs two 5G modems, connected to the system using a virtual bonding technique, to achieve redundancy.

## Project Scope
The scope of this project is to build and analyze the OPC-UA communication with a redundant 5G connection for industrial use cases. To accomplish this, we developed a client and server using C# programming on Raspberry Pi devices. C# was chosen for its performance and memory management capabilities, which are critical for IoT applications. Redundancy in the 5G communication is achieved by using two 5G modems on each side (server and client).

## Key Objectives
* Monitoring and Control Systems: Implement monitoring and control systems over a 5G network using the OPC UA protocol.
* Latency Testing: Evaluate and test the latency over long-range 5G communication.
* Proof of Concept: Demonstrate the dual-channel setup in a 5G modem to achieve redundancy in the network.


## Table of Contents
1. [Installation](#installation)
2. [Usage](#usage)
3. [Features][#Features]
4. [Testing][#Testing]
5. [Contributing](#contributing)
6. [License](#license)
7. [Acknowledgements](#acknowledgements)


## Installation
### Prerequisites
*   Raspberry Pi devices
*   5G modems (two for each Raspberry Pi)
*   .NET Core SDK
*   OPC UA libraries for C#
*   FactoryIO

### Steps
Clone the repository: 
```
git clone https://github.com/Vikneshwara-kumar/Data-Center-Infrastructure-Management-system.git
```

Navigate to the project directory: 
```
cd Data-Center-Infrastructure-Management-system
```

Build the project:  
```
dotnet build
```

Deploy the application on Raspberry Pi devices.


## Usage
1.   Starting the Server:
```
dotnet run --project Server
```

2.   Starting the Client:
```
dotnet run --project Client
```

3.   Monitoring and Control:
    Use the provided interface to monitor and control the systems over the 5G network.

## Features
*   Redundant 5G Communication: Achieve redundancy using two 5G modems connected via virtual bonding.
*   OPC UA Protocol: Utilize the OPC UA protocol for robust and secure communication.
*   Performance Optimized: Developed using C# for superior performance and memory management.

## Testing
*   Latency Testing: Conduct latency tests over long-range 5G communication to ensure reliability.
*   Redundancy Testing: Validate the redundancy setup by simulating modem failures and observing system resilience.

## Contributing
1.  Fork the repository.
2.  Create your feature branch (git checkout -b feature/AmazingFeature).
3.  Commit your changes (git commit -m 'Add some AmazingFeature').
4.  Push to the branch (git push origin feature/AmazingFeature).
5.  Open a pull request.

##  License
Distributed under the MIT License. See LICENSE for more information.

## Acknowledgements
Inspired by the advancements in 5G technology and its applications in Industry 4.0.
