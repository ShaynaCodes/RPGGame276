using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog 
{
   // public string name;
    public float position;
    public string conversation;

    [TextArea(3,10)]
    public string[] sentences;
}
