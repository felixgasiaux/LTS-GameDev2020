using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class cinematic_camera : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5f;
    float distanceTravelled;
    public GameObject ShopMenuUI;
    public EndOfPathInstruction endOfPathInstruction;
    public bool camera_move = false;
    public float time = 0;
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
            }
            else
            {
                speed = 10f;
            }
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);// Stop or Loop
        }
        else
        {
            ShopMenuUI.SetActive(true);
            if (time >= 12f)
            {
                camera_move = true;
                ShopMenuUI.SetActive(true);
            }
        }
    }
}
