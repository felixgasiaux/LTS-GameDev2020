using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Red_Girl_Controller : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 0.5f;
    private float distanceTravelled;
    // Start is called before the first frame update
    void Update()
    {

        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    }

}
