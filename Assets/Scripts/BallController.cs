using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    Transform Parent;
    public GameObject Bumbina;
 
    
    

    void Start ()
    {
        
        GameObject InstantiatedGameObject= Instantiate(Bumbina);
        InstantiatedGameObject.transform.SetParent(Parent);
       
    }

    /*
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f ,moveVertical);

        rb.AddForce (movement * speed);

    }
*/
   

}
