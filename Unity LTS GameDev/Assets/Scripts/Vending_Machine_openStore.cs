using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vending_Machine_openStore : MonoBehaviour
{
    public GameObject ShopUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player entered shop area");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Player opened the shop");
            ShopUI.SetActive(true);
        }
    }
}
