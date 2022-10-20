using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    float speed = 10f;
    float speed2 = 5f;
    float speedDown = 8f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        { 
                transform.position += Vector3.left  * speed2 * Time.deltaTime; ;
            transform.Rotate(transform.forward, 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed2*Vector3.right * Time.deltaTime;
            transform.Rotate(Vector3.up, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward *speedDown* Time.deltaTime;
        }    
    }
}
