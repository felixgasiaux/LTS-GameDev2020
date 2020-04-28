using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wship_controller : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 10f;
    float distanceTravelled;
    public EndOfPathInstruction endOfPathInstruction;
    public float time = 0;
    public GameObject title;
    public Text conversation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);// Stop or Loop
        if (time < 5f)
        {
            title.SetActive(false);
            conversation.text = "MISSION CONTROL : 5th colony, this is Houston. You are GO for staging. ";
        }
        else if (time < 8f)
        {
            conversation.text = "5TH COLONY : Inboard cut-off.  ";
        }
        else if (time < 11f)
        {
            conversation.text = "MISSION CONTROL : We confirm inboard cut-off.  ";
        }
        else if (time < 14f)
        {
            conversation.text = "5TH COLONY : Staging. And ignition.";
        }
        else if (time < 17f)
        {
            conversation.text = "MISSION CONTROL : 5, Houston. Thrust is GO, all engines. You're looking good. ";
        }
        else if (time < 20f)
        {
            conversation.text = "5TH COLONY : Roger. You're loud and clear, Houston. ";
        }
        else if (time < 23f)
        {
            conversation.text = "5TH COLONY : We've got skirt SEP. ";
        }
        else if (time < 26f)
        {
            conversation.text = "MISSION CONTROL : Roger. We confirm. Skirt SEP. ";
        }
        else if (time < 29f)
        {
            conversation.text = "5TH COLONY : Tower's gone. ";
        }
        else if (time < 32f)
        {
            conversation.text = "MISSION CONTROL : Roger.Tower. ";
        }
        else if (time < 35f)
        {
            conversation.text = "5TH COLONY : Houston, be advised the visual is GO today. ";
        }
        else if (time < 38f)
        {
            conversation.text = "MISSION CONTROL : This is Houston. Roger. Out.";
        }
        else if (time < 41f)
        {
            conversation.text = "5TH COLONY : Yes.They finally gave me a window to look out. ";
        }
        else if (time < 44f)
        {
            conversation.text = "MISSION CONTROL : 5, Houston.Your guidance has converged, you're looking good. ";
        }
        else if (time < 47f)
        {
            conversation.text = "5TH COLONY : Roger.";
        }
        else if (time < 50f)
        {
            conversation.text = "MISSION CONTROL : 5, Houston.You are GO at 5 minutes.";
        }
        else if (time < 53f)
        {
            conversation.text = "MISSION CONTROL : bzzzzz-biiiiiiip";
        }
        else if (time < 56f)
        {
            conversation.text = "5TH COLONY : Houston ? We can't hear you. Out";
        }
        else if (time < 59f)
        {
            conversation.text = "MISSION CONTROL : frrrrrrr-tchhhhh";
        }
        else if (time < 61f)
        {
            conversation.text = "5TH COLONY : Houston ? Commit. Out";
        }
        else if (time < 64f)
        {
            conversation.text = "MISSION CONTROL : -silence-";
        }
        else if (time < 67f)
        {
            conversation.text = "5TH COLONY : Houston their seems to be a problem with the comms";
        }
        else if (time < 80f)
        {
            conversation.text = "5TH COLONY : Landing on-going, hope we get comms back at tranquillity base";
        }
        else if (time < 99f)
        {
            title.SetActive(true);
            conversation.text = "";
        }
        else if (time > 99.17f)
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetKeyDown("e"))
        {
            print("exit");
            SceneManager.LoadScene("Menu");
        }

    }
}
