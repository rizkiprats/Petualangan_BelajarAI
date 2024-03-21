using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    // Start is called before the first frame update

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(0f, 0f, 1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(0f, 0f, -1f);
        }
    }
}
