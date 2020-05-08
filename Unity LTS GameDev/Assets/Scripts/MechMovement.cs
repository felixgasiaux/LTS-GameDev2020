using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Pathfinding
{
    public class MechMovement : MonoBehaviour
    {
        public float moveSpeed = 3f;
        public string collision;
        public Rigidbody2D rb;
        public Animator animator;
        Vector2 movement;
        public Transform target;
        IAstarAI[] ais;
        public void Start()
        {
            ais = FindObjectsOfType<MonoBehaviour>().OfType<IAstarAI>().ToArray();
        }
        // Update is called once per frame
        void Update()
        {
            // input because reapeated less times
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
            for (int i = 0; i < ais.Length; i++)
            {
                if (ais[i] != null) ais[i].SearchPath();

            }
        }

        void FixedUpdate()
        {
            // movement because reapeated more times
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        }
        void OnCollisionEnter2D(Collision2D col)
        {

            collision = col.gameObject.name;
        }
    }
}