﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_button : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Base");
    }
}
