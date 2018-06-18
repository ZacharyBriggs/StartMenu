using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu(menuName = "MyStuff")]
public class GlobalGameManager : ScriptableObject
{
    public void StartButton()
    {
        Debug.Log("game has started");
    }

    public void EndButton()
    {
        Debug.Log("game has ended");
    }

    public void OptionsButton()
    {
        Debug.Log("options menu opened");
    }
}
