using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBishopMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position += new Vector3(18f, 0, -18);
        }
    }
}
