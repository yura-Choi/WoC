﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour {

    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("InGame03");
    }
}
