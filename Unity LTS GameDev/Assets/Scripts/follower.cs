using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    public Animator animator;
    float distanceTravelled;
    int posx;
    int posy;
    int directionx;
    int directiony;
    // Start is called before the first frame update
    void Update()
    {
        int posx = (int)pathCreator.path.GetPointAtDistance(distanceTravelled).x;
        int posy = (int)pathCreator.path.GetPointAtDistance(distanceTravelled).y;
        if (posx == (int)pathCreator.path.GetPointAtDistance(distanceTravelled).x){
            directionx = 0;
        }
        if (posy == (int)pathCreator.path.GetPointAtDistance(distanceTravelled).y){
            directionx = 0;
        }
        if (posx >= (int)pathCreator.path.GetPointAtDistance(distanceTravelled).x){
            directionx = -1;
        }
        if (posy >= (int)pathCreator.path.GetPointAtDistance(distanceTravelled).y){
            directiony = -1;
        }
        if( posx <= (int)pathCreator.path.GetPointAtDistance(distanceTravelled).x){
            directionx = 1;
        }
        if (posy <= (int)pathCreator.path.GetPointAtDistance(distanceTravelled).y){
            directiony = 1;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        animator.SetFloat("pos x", directionx);
        animator.SetFloat("pos y", directiony);
        Debug.Log("posx =" + posx + "posy =" + posy +"real position ="+ pathCreator.path.GetPointAtDistance(distanceTravelled));

    }
}
