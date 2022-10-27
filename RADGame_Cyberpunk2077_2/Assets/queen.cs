using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class queen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += new Vector3(-24f, 0, 24);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(-12f, 0, -12);


        }
    }
}
