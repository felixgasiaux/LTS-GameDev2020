using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal_down : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Outside");
        Debug.Log("Player went outside");
    }

    // Update is called once per frame
    void Update()
    {

    }
}