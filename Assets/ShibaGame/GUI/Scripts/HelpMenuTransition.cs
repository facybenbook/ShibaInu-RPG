﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMenuTransition : MonoBehaviour
{
    [SerializeField]
    private string transitionScene = null;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene(transitionScene);
        }
    }
}
