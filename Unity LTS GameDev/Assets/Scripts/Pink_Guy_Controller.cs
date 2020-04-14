using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pink_Guy_Controller : MonoBehaviour
{
    public bool talktopink;
    public static bool inboxcollider = false;
    public GameObject PinkGuy_Talk;
    public TextMeshPro UIConversation;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player entered Talking area");
        inboxcollider = true;
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
            }
            else
            {
                
            }
        }
    }
}
