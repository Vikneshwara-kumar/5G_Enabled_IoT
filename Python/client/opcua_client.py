from opcua import Client
import time
from opcua import ua
client = Client("opc.tcp://192.168.1.11:4840")
#client = Client("opc.tcp://192.168.1.105:53445/OPCUA/simulation_server")
try:
    client.connect()
    print ("client connected")
    
    inp= client.get_node("ns=4;s=|var|CODESYS Control for Raspberry Pi MC SL.Application.POU_App.aInput2")
    input= inp.get_value()
    print("Input-gw values:",input)
    #send the values from client to server
    inp.set_value(ua.Variant([25,13,14,15,16,17,18,19,20,21,22,23,24,25,26,0],ua.VariantType.Byte))
    #inp.set_value({[0]:25,[1]:13,[2]:14,[3]:15,[4]:16,[5]:17,[6]:18,[7]:19,[8]:20,[9]:21,[10]:22,[11]:23,[12]:24,[13]:25,[14]:26,[15]:0})
    #send the values from client to server
    op= client.get_node("ns=4;s=|var|CODESYS Control for Raspberry Pi MC SL.Application.POU_App.aOutput1")
    op.set_value(ua.Variant([100,1,3,2,5,7,4,1,2,3,4,9,7,8,13,12],ua.VariantType.Byte))
    output= op.get_value()
    print("Output-gw values:",output)   
    time.sleep(1)
finally:
    client.disconnect()


