﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuitter : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
