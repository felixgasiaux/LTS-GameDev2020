using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Vending_Machine_openStore : MonoBehaviour
{

    public static bool Shopcanbeopened = false;
    public GameObject ShopMenuUI;
    public bool Shopisopen;
    public GameObject PressEtointeract;
    public GameObject Mission_Text;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player entered shop area");
        Shopcanbeopened = true;
        PressEtointeract.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Player exited shop area");
        Shopcanbeopened = false;
        PressEtointeract.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Shopcanbeopened == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Shopisopen)
                {
                    Resume();
                    Debug.Log("Shop is closed");
                }
                else
                {
                    Pause();
                    Debug.Log("Shop is opened");
                }
            }
        }
    }

    public void Resume()
    {
        ShopMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Shopisopen = false;
        Mission_Text.SetActive(true);
    }

    void Pause()
    {
        ShopMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Shopisopen = true;
        PressEtointeract.SetActive(false);
        Mission_Text.SetActive(false);

    }
}
