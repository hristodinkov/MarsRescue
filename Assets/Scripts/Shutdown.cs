using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Shutdown : MonoBehaviour
{
    public void ShutDown()
    {
        Process.Start("shutdown.exe","-s -t 00");
    }
}
