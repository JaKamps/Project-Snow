using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float Movement;
    public Vector3 Axis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //movement
        Axis.x = Input.GetAxis("Horizontal");
        Axis.z = Input.GetAxis("Vertical");
        transform.position += Axis*Movement/100;
    }
}
