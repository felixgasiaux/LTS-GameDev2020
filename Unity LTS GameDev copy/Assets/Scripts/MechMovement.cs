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
        public int metal;
        public int life = 100;
        public Slider lSlider;
        public float moveSpeed = 3f;
        public string collision;
        public Rigidbody2D rb;
        public Animator animator;
        Vector2 movement;
        public Transform target;
        IAstarAI[] ais;
        public Slider mSlider;
        public GameObject metal1;
        public GameObject metal2;
        public GameObject metal3;
        public GameObject metal4;
        public GameObject metal5;
        private static bool MetalCollect = false;
        public GameObject PressEtocollect;
        private string metal_name;

        public void Start()
        {
            ais = FindObjectsOfType<MonoBehaviour>().OfType<IAstarAI>().ToArray();
            metal1.SetActive(true);
            metal2.SetActive(true);
            metal3.SetActive(true);
            metal4.SetActive(true);
            metal5.SetActive(true);
        }
        // Update is called once per frame
        void Update()
        {
            mSlider.value = metal;
            if (MetalCollect == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    metal += 20;
                    MetalCollect = false;
                    if (metal_name == "metal1")
                    {
                        metal1.SetActive(false);
                    }
                    else if (metal_name == "metal2")
                    {
                        metal2.SetActive(false);
                    }
                    else if (metal_name == "metal3")
                    {
                        metal3.SetActive(false);
                    }
                    else if (metal_name == "metal4")
                    {
                        metal4.SetActive(false);
                    }
                    else if (metal_name == "metal5")
                    {
                        metal5.SetActive(false);
                    }

                }
            }
            lSlider.value = life;
            if (life == 0)
            {
                SceneManager.LoadScene("You died");
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
            if (col.gameObject.name == "Sprite" || col.gameObject.name == "Sprite (1)" || col.gameObject.name == "Sprite (2)" || col.gameObject.name == "Sprite (3)" || col.gameObject.name == "Sprite (4)" || col.gameObject.name == "Sprite (5)" || col.gameObject.name == "Sprite (6)" || col.gameObject.name == "Sprite (7)" || col.gameObject.name == "Sprite (8)" || col.gameObject.name == "Sprite (9)" || col.gameObject.name == "Sprite (10)" || col.gameObject.name == "Sprite (11)" || col.gameObject.name == "Sprite (12)" || col.gameObject.name == "Sprite (13)" || col.gameObject.name == "Sprite (14)" || col.gameObject.name == "Sprite (15)")
            {
                life -= 20;
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            metal_name = collision.gameObject.name;
            if (metal_name == "metal1" | metal_name == "metal2" | metal_name == "metal3" | metal_name == "metal4" | metal_name == "metal5")
            {

                Debug.Log("Player entered collect area");
                MetalCollect = true;
                PressEtocollect.SetActive(true);

            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            Debug.Log("Player exited collect area");
            MetalCollect = false;
            PressEtocollect.SetActive(false);
        }
    }
}