using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vending_Machine_openStore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player entered shop area");

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Player Opened The Shop");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
