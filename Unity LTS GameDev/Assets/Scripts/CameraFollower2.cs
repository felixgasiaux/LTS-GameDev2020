using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class CameraFollower2 : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 10f;
    public float distanceTravelled;
    public EndOfPathInstruction endOfPathInstruction;
    public int shake;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shake += 1;
        if (shake == 10)
        {
            distanceTravelled -= 5f;
        }
        else if (shake == 5)
        {
           distanceTravelled += 5f;
        }
        else if (shake == 11)
        {
            shake = 0;
        }
        else
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);// Stop or Loop
        }
    }
}
