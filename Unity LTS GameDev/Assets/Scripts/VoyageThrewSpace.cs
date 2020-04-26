using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.SceneManagement;

public class VoyageThrewSpace : MonoBehaviour
{
    public EndOfPathInstruction endOfPathInstruction;
    public float time = 0;
    public PathCreator pathCreator;
    public float speed = 0f;
    float distanceTravelled;
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
        if (time > 34.5f)
        {
            speed -= 1f;
            if (speed <= 3f){
                speed = 3f;
            }
        }
        else
        {
            speed += 0.01f;
        }
        if (time > 41.1f)
        {
            SceneManager.LoadScene("VoyageThrewSpace");
        }
    }
}
