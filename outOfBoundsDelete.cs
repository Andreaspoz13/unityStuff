using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBoundsDelete : MonoBehaviour
{
    private float topBoundary = 60.5f;
    private float bottomBoundary = -15.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBoundary)
        {
            Destroy(gameObject);
            
        }
        if(transform.position.z > topBoundary)
        {
            transform.Translate(0, 1.636f, 1.582f);
        }else if(transform.position.z < bottomBoundary)
        {
            Destroy(gameObject);
        }

        
    }
}

