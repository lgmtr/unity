using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;

public class NativePluginTest : MonoBehaviour {

    [DllImport("TestPlugin")]
    private static extern int GetRandomX();
    [DllImport("TestPlugin")]
    private static extern int GetRandomY();
    [DllImport("TestPlugin")]
    private static extern int GetRandomZ();
    [DllImport("TestPlugin")]
    private static extern IntPtr EchoString(string echoString);


    void Start () {
        print("RandX: " + GetRandomX());
        print("RandY: " + GetRandomY());
        print("RandZ: " + GetRandomZ());
        print("Echo: " + Marshal.PtrToStringAnsi(EchoString("Some Echo String")));
    }
	
}
