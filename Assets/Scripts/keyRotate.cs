using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyRotate : MonoBehaviour
{
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
             GetComponent<Rigidbody>().transform.Rotate(0,force*Time.deltaTime,0);

         if (Input.GetKey(KeyCode.LeftArrow))
             GetComponent<Rigidbody>().transform.Rotate(0,-force*Time.deltaTime,0);
    }

}
        
        
    

