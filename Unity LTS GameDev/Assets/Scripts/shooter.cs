using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public Animator animator;
    private bool MouseDown = false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            MouseDown = true;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null)
            {
                Debug.Log("touched something" + hit.collider);
            }
            else
            {
                Debug.Log("touched nothing");
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            MouseDown = false;
        }
        animator.SetBool("MouseDown", MouseDown);
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack_cursor"))
        {
            transform.position = cursorPos;
        }
        else { }
    }
}
