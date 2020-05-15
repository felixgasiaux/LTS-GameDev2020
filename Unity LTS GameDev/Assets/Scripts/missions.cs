using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missions : MonoBehaviour
{
    public GameObject button;
    public GameObject mission;
    private bool open;
    // Start is called before the first frame update
    void Start()
    {
        mission.SetActive(false);
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pressed()
    {
        if (open == false)
        {
            mission.SetActive(true);
            open = true;
        }
        else
        {
            mission.SetActive(false);
            open = false;
        }
    }
}
