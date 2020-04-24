using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.UI;

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
            if (time < 55.5f)
            {
                speed = 0.5f;
                if (time > 48.1f)
                {
                    conversation.text = "";
                }
                else if (time > 20.3f)
                {
                    conversation.text = "EARTH - 2069";
                }
            }
            else if (time > 55.5f)
            {
                speed = 15f;
                if (time < 65.3f)
                {
                    conversation.text = "In 2069";
                }
                else if (time < 72.3f)
                {
                    conversation.text = "A crew of 6 austronauts";
                }
                else if (time < 85.3f)
                {
                    conversation.text = "Begins their journey threw our solar system";
                }
                else if (time < 95.3f)
                {
                    conversation.text = "To Titan a moon orbiting around Saturn";
                }
                
            }
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);// Stop or Loop
        }
        else
        {
            if (time >= 12f)
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
