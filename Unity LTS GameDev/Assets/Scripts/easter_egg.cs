using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class easter_egg : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Special_room");
        Debug.Log("Easter egg !!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
