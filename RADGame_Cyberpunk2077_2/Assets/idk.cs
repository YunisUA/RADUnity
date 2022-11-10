using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idk : MonoBehaviour
{
    float currentTime = 0;
    float Max = 10;
    int myHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        
    {
        currentTime += Time.deltaTime;
        if (currentTime> Max)
        {
            Destroy(gameObject);
        }
    }
    internal void takeDamage(int amountOfDamage)
    {
        myHealth -= amountOfDamage;
        if (myHealth <=0)
        {
            Rigidbody myRigidBody = GetComponent<Rigidbody>();
            Destroy(myRigidBody);
            print("I'm dead");
        }
        print("You hurt me with" + amountOfDamage.ToString());
    }
}
