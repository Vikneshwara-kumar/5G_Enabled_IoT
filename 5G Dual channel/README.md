# Note: This repo will be available for a limited period of time

### 5G-OMLOX_NotHalt
A PoC for using Geo-fences in Omlox localized area to dynamically control the behavoiur of 5G connected devices

# Development of redundant 5G-NH
 - both devices connected to 5G
 - bonding both devices
 -  bash script prepared for port bonding of two interfaces
 - Test communication over bonded NIC with ping, nload
 - HW-Test with button and LED
# Integration to the localization system
- WebSocket client program prepared in C# for Omlox-System
- Define three zones in the ZCPS lab
based on x coordinates, the three zones are defined with following limits and names

0    mm - 2400 mm | Festo CP Area
2400 mm - 8100 mm | Working Area
8200 mm - 9999 mm | Creative-Room

# Test localization and 5G
![image](https://user-images.githubusercontent.com/47817165/162728153-1e5cfc5c-630a-4120-b4e4-8317ae7a45b7.png)
