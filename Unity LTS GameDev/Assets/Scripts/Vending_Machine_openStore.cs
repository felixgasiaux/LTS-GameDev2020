using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Vending_Machine_openStore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player entered shop area");
        Shopcanbeopened = true;
    }

    public static bool Shopcanbeopened = false;
    public GameObject ShopMenuUI;
    public bool Shopisopen;

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
    }

    void Pause()
    {
        ShopMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Shopisopen = true;
    }
}
