using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LastCinematic : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 0f;
    public float distanceTravelled;
    public GameObject head1;
    public GameObject head2;
    public GameObject head3;
    public GameObject head4;
    public GameObject head5;
    public GameObject head6;
    public Text conversation;
    public EndOfPathInstruction endOfPathInstruction;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        head1.SetActive(false);
        head2.SetActive(false);
        head3.SetActive(false);
        head4.SetActive(false);
        head5.SetActive(false);
        head6.SetActive(false);
        conversation.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (distanceTravelled >= 841.2007f)
        {
            SceneManager.LoadScene("LastCinematic");
        }
        else if (distanceTravelled > 750f)
        {
            speed -= 0.1f;
            if (speed <= 1f)
            {
                speed = 1f;
            }
        }
        else
        {
            speed += 0.01f;
        }
                if (time < 5f)
                {
                    conversation.text = "The crew has been training for 5 years";
                }
                else if (time < 10f)
                {
                    head1.SetActive(true);
                    conversation.text = "Pilote Lucie";
                }
                else if (time < 15f)
                {
                    head2.SetActive(true);
                    conversation.text = "Commander Emma";
                }
                else if (time < 20f)
                {
                    head3.SetActive(true);
                    conversation.text = "Communication engineer Luc";
                }
                else if (time < 25f)
                {
                    head4.SetActive(true);
                    conversation.text = "Command pilote Martin";
                }
                else if (time < 30f)
                {
                    head5.SetActive(true);
                    conversation.text = "Titan module pilote Quentin";
                }
                else if (time < 35f)
                {
                    head6.SetActive(true);
                    conversation.text = "Mechanical engineer Felix";
                }
                else if (time > 45.5f)
                {
                    conversation.text = "";
                 }

            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);// Stop or Loop
        }
        }

