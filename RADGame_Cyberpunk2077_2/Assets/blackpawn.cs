using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position += new Vector3(6f, 0, 0);
        }
    }
}
