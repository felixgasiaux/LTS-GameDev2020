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
    public GameObject ShopMenuUI;
    public EndOfPathInstruction endOfPathInstruction;
    public bool camera_move = false;
    public float time = 0;
    public Text conversation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (camera_move == true)
        {
            if (time < 26.5f)
            {
                speed = 1.5f;
                if (time > 25f)
                {
                    conversation.text = "";
                }
                else if (time > 15f)
                {
                    conversation.text = "EARTH - 2069";
                }
            }
            else if (time > 24f)
            {
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
                else if (time > 54f)
                {
                    SceneManager.LoadScene("VoyageThrewSpace");
                }


            }
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);// Stop or Loop
        }
        else
        {
            if (time >= 10f)
            {
                camera_move = true;
                ShopMenuUI.SetActive(false);
            }
            else
            {
                conversation.text = "";
                ShopMenuUI.SetActive(true);
            }
        }
    }
}
