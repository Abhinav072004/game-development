using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
    public float keyinput;
   
    void Start()
    {



    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);

        }

        keyinput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3(keyinput, GetComponent<Rigidbody>().velocity.y, 0);

    }
}
