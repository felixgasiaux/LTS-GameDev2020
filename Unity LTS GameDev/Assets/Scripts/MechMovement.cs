using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Pathfinding
{
    public class MechMovement : MonoBehaviour
    {
        public int life = 100;
        public Slider mSlider;
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
            mSlider.value = life;
            if (life == 0)
            {
                SceneManager.LoadScene("Menu");
                Debug.Log("Player died");
            }
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

            Debug.Log(col.gameObject.name);
            if (col.gameObject.name == "Sprite" || col.gameObject.name == "Sprite (1)" || col.gameObject.name == "Sprite (2)" || col.gameObject.name == "Sprite (3)" || col.gameObject.name == "Sprite (4)" || col.gameObject.name == "Sprite (5)" || col.gameObject.name == "Sprite (6)"  || col.gameObject.name == "Sprite (7)" || col.gameObject.name == "Sprite (8)" || col.gameObject.name == "Sprite (9)" || col.gameObject.name == "Sprite (10)" || col.gameObject.name == "Sprite (11)" || col.gameObject.name == "Sprite (12)" || col.gameObject.name == "Sprite (13)" || col.gameObject.name == "Sprite (14)" || col.gameObject.name == "Sprite (15)")
            {
                life -= 20;
            }
        }
    }
}