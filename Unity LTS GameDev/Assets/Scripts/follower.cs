using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    /*
    public Animator animator;
    int posx;
    int posy;
    float directionx;
    float directiony;
    */
    // Start is called before the first frame update
    void Update()
    {
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        /*
        int posx = (int)pathCreator.path.GetPointAtDistance(distanceTravelled).x;
        int posy = (int)pathCreator.path.GetPointAtDistance(distanceTravelled).y;
        if (posx == (int)pathCreator.path.GetPointAtDistance(distanceTravelled).x)
        {
            directionx = 0f;
        }
        if (posy == (int)pathCreator.path.GetPointAtDistance(distanceTravelled).y)
        {
            directionx = 0f;
        }
        if (posx >= (int)pathCreator.path.GetPointAtDistance(distanceTravelled).x)
        {
            directionx = -1f;
        }
        if (posy >= (int)pathCreator.path.GetPointAtDistance(distanceTravelled).y)
        {
            directiony = -1f;
        }
        if (posx <= (int)pathCreator.path.GetPointAtDistance(distanceTravelled).x)
        {
            directionx = 1f;
        }
        if (posy <= (int)pathCreator.path.GetPointAtDistance(distanceTravelled).y)
        {
            directiony = 1f;
        }
        animator.SetFloat("pos x", directionx);
        animator.SetFloat("pos y", directiony);


        Debug.Log("posx =" + posx + " posy =" + posy +" real position ="+ pathCreator.path.GetPointAtDistance(distanceTravelled));
        */
        

    }
}
