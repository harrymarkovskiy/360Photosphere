﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAnotherScene : MonoBehaviour
{
    public string SceneToLoad;
    public void LoadScene()
    {
        SceneManager.LoadScene (SceneToLoad);
    }
}
