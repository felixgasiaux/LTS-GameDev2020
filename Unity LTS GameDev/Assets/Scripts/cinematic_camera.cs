using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class cinematic_camera : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5f;
    float distanceTravelled;
    public EndOfPathInstruction endOfPathInstruction;
    public float time = 24f;
    public Text conversation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        speed = 25f;
        if (time < 29f)
        {
            conversation.text = "In 2069";
        }
        else if (time < 34f)
        {
            conversation.text = "A crew of 6 austronauts";
        }
        else if (time < 39f)
        {
            conversation.text = "Begins their journey threw our solar system";
        }
        else if (time < 44f)
        {
            conversation.text = "To Titan a moon orbiting around Saturn";
        }
        else if (time < 49f)
        {
            conversation.text = "To create the 5th colony";
        }
        else if (time < 54f)
        {
            SceneManager.LoadScene("VoyageThrewSpace");
        }

        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);// Stop or Loop
        if (Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}