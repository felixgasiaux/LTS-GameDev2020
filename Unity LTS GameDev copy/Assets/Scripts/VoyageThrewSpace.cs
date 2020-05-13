using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;


public class VoyageThrewSpace : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 0f;
    float distanceTravelled;
    public EndOfPathInstruction endOfPathInstruction;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        speed += 0.01f;
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);// Stop or Loop
    }
}
