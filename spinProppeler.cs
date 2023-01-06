using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinProppeler : MonoBehaviour

{
    public float turnSpeed = 500.0f;
    public float verticalInput = 150.0f;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update(){

        
       transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed * verticalInput); 
    }
}
