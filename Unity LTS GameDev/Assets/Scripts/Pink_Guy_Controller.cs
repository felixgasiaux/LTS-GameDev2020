using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pink_Guy_Controller : MonoBehaviour
{
    public bool talktopink;
    public static bool inboxcollider = false;
    public GameObject PinkGuy_Talk;
    public Text UIConversation;
    public GameObject PressEtointeract;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player entered Talking area");
        inboxcollider = true;
        PressEtointeract.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Player left Talking area");
        inboxcollider = false;
        PressEtointeract.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inboxcollider == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Player is talking to Pink Guy");
                PinkGuy_Talk.SetActive(true);
                Time.timeScale = 0f;
                UIConversation.text = "Hello";
                PressEtointeract.SetActive(false);

            }
            else
            {
                
            }
        }
    }
}
