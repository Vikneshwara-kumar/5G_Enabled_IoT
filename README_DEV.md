# 5G-OMLOX_NotHalt - Development

developing the basic button-LED communication on branch develop

developing the button-LED communication over openSafety on branch openSafety

git checkout openSafety

make changes in code

git push --set-upstream origin openSafety

creating tests on branch testing


## Configuration of the Raspberry Pis

### Device 01 (+Switch)
Name Server 
IP:- 192.168.1.10

### Device 02 (+LED)
Name Client
IP:- 192.168.1.12

Ping test done sucessfully
Server and client communication tested with 2 devices
sucessfully sent and received string.

Before we can use the 5G-OMLOX_NotHalt via 5G, some installation and configuration has to be done. The steps presented in this documentation must be followed on both devices (Raspberry Pis).  

### Step 1 - Installing the operating system
First we need to install the operationg system. Ubuntu 21.10 will be used, because the modem manger is required for the 5G-Connection. In raspbian you can also find and install the modem manager via `apt`, but you will get an old version which does not support 5G. You can try to use the "testing" or "unstable" versions of the modem-manager, but this was not tested yet.

To install the operating system on the Raspberry Pis, follow these steps:
1. Download the [Raspberry Pi Imager](https://www.raspberrypi.com/software/)
2.  For each versions of the Raspberry Pi Compute module:
    - SD-Card - Insert the SD-Card into a SD-Card-Reader connected to your computer. 
    - EEPROM - Download rpiboot ([Linux](https://github.com/raspberrypi/usbboot), [Mac](https://github.com/raspberrypi/usbboot), [Windows](https://github.com/raspberrypi/usbboot/tree/master/win32)). Connect the TOFU Oratec board via USB-C to your computer, while holding down the button beside the ethernet port ("BOOT"). Run rpiboot on your computer.
3. Run the Raspberry Pi Imager
4. "Choose OS" > "Other general purpose OS" > "Ubuntu" > "Ubuntu Server 21.10 (RPi 3/4/400) - 64-bit"
5. "Choose Storage" - Here you will also find the connected RPi with EEPROM
6. "Write"

### Step 2 - Installing software tools and updates
After the OS installation, connect the RPi to the network via ethernet and use a SSH client to connect to the Raspberry Pi (User: ubuntu - Password: ubuntu). Now choose a new password and update the system with `sudo apt update` and `sudo apt upgrade`. Install the necessary packages with the following command:

`sudo apt install -y net-tools network-manager modemmanager`

#### dotnet 6
dotnet 6 is required to run the code on the raspberry pi. 
installation https://docs.microsoft.com/de-de/dotnet/core/install/linux-ubuntu

Test the installaion with
`dotnet --version`

Build and run the project with the following commands

#[ TODO #1 -Viki]
`cd ..?`

`dotnet ..`

`dotnet ..`

After cloning / pulling the repo, the dll files should be deleted --> TODO #2 .gitignore these files to avoid uploading them to the repo.
On a Raspberrypi the path to the projects (Server/Client) shoud be granted permissions
`sudo chmod -R 757 '/home/pi/...'`

in the path of every project, restore, build and run the project
`dotnet restore`

`dotnet build`

`dotnet run`

### Step 3 - The electrical circuit
connect the circuit correctly to the GPIOs. 
https://docs.microsoft.com/de-de/dotnet/iot/tutorials/blink-led

![image](https://user-images.githubusercontent.com/47817165/160644996-ee08e042-6c12-471e-9527-935f9ac39005.png)


The switch should be connected with pulldown-resistance
https://www.elektronik-kompendium.de/sites/raspberry-pi/2006051.htm

![image](https://user-images.githubusercontent.com/47817165/160644608-099a8e65-f835-4f89-9ea9-86ce9ecd4d3d.png)

### Step 4 - Configure the 5G network connection
Now the 5G connection can be configured. First, look for the right device name. Use `ifconfig` and search for it. In most cases, the name is `cdc-wdm0`.
Use following two commands to configure the 5G connection:

`sudo nmcli connection add type gsm con-name mobile ifname cdc-wdm0 apn internet`

`sudo nmcli connection up mobile`
