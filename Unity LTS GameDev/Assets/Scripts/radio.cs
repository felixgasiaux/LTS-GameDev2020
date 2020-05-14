using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radio : MonoBehaviour
{
    public GameObject PressEtorepair;
    private bool radiocanbeopen;
    public GameObject radio_group;
    private bool radioopen;
    public GameObject aim;

    // Start is called before the first frame update
    void Start()
    {
        radiocanbeopen = false;
        radioopen = false;
        radio_group.SetActive(false);
        aim.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (radiocanbeopen == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E pressed"+radioopen);
                if (radioopen == false)
                {
                    radio_group.SetActive(true);
                    PressEtorepair.SetActive(false);
                    aim.SetActive(false);
                    Cursor.visible = true;
                    radioopen = true;
                }
                else
                {
                    radio_group.SetActive(false);
                    PressEtorepair.SetActive(true);
                    aim.SetActive(true);
                    Cursor.visible = false;
                    radioopen = false;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PressEtorepair.SetActive(true);
        radiocanbeopen = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        PressEtorepair.SetActive(false);
        radiocanbeopen = false;
    }
    public void repair()
    {
        Debug.Log("repair");
    }
}

