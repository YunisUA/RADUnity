using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKnightBlack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position += new Vector3(12f, 0, -6);
        }
    }
}
