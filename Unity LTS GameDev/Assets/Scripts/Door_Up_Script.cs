using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Up_Script : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Base");
        Debug.Log("Player went to the first room");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
