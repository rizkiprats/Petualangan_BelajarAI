using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Story
{
    public string name;
    [TextArea(2, 10)]
    public string[] sentences;
}