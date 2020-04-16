using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading_position : MonoBehaviour
{
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = Input.mousePosition;
        if (pos.y < 185f)
        {
            transform.position = new Vector3(3f, -1.4f, 1f);
        }
        else if (pos.y < 300f)
        {
            transform.position = new Vector3(3f, -0.3f, 1f);

        }
        else if (pos.y < 440f)
        {
            transform.position = new Vector3(3f, 1.2f, 1f);
        }
        Debug.Log(pos);
    }
}
