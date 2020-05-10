using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class metal_behaviour : MonoBehaviour
{
    public static bool MetalCollect = false;
    public bool MetalCollected = false;
    public GameObject PressEtocollect;
    public GameObject Object;
    void Start()
    {
        Object.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (MetalCollected == false)
        {
            Debug.Log("Player entered collect area");
            MetalCollect = true;
            PressEtocollect.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Player exited collect area");
        MetalCollect = false;
        PressEtocollect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MetalCollect == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("metal collected");
                MetalCollected = true;
                PressEtocollect.SetActive(false);
                Object.SetActive(false);
                MetalCollect = false;

            }
        }
    }

}
