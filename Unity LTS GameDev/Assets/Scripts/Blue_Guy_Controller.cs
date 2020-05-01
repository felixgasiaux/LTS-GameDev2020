using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using PathCreation;

public class Blue_Guy_Controller : MonoBehaviour
{
    public bool talktopink;
    public static bool inboxcollider = false;
    public GameObject PinkGuy_Talk;
    public GameObject PressEtointeract;
    public PathCreator pathCreator;
    public float speed = 0.5f;
    float distanceTravelled;
    public TextMeshProUGUI text;
    public GetComponent<Animation>() anim;


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
    void Start()
    {
        foreach (AnimationState state in anim)
        {
            state.speed = 10F;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (inboxcollider == true)
        {
            foreach (AnimationState state in anim)
            {
                state.speed = 0F;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Player is talking to Pink Guy");
                PinkGuy_Talk.SetActive(true);
                PressEtointeract.SetActive(false);
            }
            else
            {

            }
        }
        else
        {
            //movement
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            foreach (AnimationState state in anim)
            {
                state.speed = 10F;
            }
        }
    }
}
