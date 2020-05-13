using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_button : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            print("exit");
            SceneManager.LoadScene("Menu");
        }
    }
}
