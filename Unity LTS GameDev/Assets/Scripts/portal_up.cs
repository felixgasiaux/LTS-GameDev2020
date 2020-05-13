using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal_up : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Room2");
        Debug.Log("Player went inside");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
