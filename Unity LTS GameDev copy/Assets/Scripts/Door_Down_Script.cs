using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Down_Script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Room2");
        Debug.Log("Player went to the other room");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
