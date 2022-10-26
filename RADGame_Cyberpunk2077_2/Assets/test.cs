using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            myRigidbody.AddExplosionForce(1000, transform.position + Vector3.down+Vector3.back,2);
        }
        if (Input.GetKey(KeyCode.W)) 
        {
            myRigidbody.AddForce(Vector3.up);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.AddForce(Vector3.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            myRigidbody.AddForce(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            myRigidbody.AddForce(Vector3.back);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
        
    }
}
