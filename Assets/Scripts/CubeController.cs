using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 currentRotation;
    


    void Start()
    {
        
    }

    void Update()
    {
        currentRotation = GetComponent<Transform>() .eulerAngles;

        if((Input.GetAxis("Horizontal") > 0.2) && (currentRotation.z <= 8 || currentRotation.z >=350))
        {
            transform.Rotate(0,0,1);
        }
        if((Input.GetAxis("Horizontal") < -0.2) && (currentRotation.z >= 351 || currentRotation.z <= 9))
        {
            transform.Rotate(0,0,-1);
        }
        if(Input.GetAxis("Vertical") > 0.2)
        {
            transform.Rotate(1,0,0);
        }
        if(Input.GetAxis("Vertical") < -0.2)
        {
            transform.Rotate(-1,0,0);
        }
    }
    
}
