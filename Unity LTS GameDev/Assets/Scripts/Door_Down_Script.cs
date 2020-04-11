using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Down_Script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Outside");
        Debug.Log("Player went to the outside");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
