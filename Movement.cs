
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float jumpForce = 500f;

    public float forwardForce = 200f;

    public float sidewaysForce = 200f;

    public float goBehind = 500f;

    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("Hello!!");  
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(forwardForce, 0, 0);
        
        if(Input.GetKey("w")){
            rb.AddForce(forwardForce, 0, 0);
        }
        

        if(Input.GetKey("space")){
        rb.AddForce(0, jumpForce, 0);
        }
        if(Input.GetKey("d")){
          rb.AddForce(0, 0, -sidewaysForce);
        }
        if(Input.GetKey("s")){
          rb.AddForce(-goBehind, 0, 0);
        }
        if(Input.GetKey("a")){
          rb.AddForce(0, 0, sidewaysForce);
        }
        
        

    }

    }

    


