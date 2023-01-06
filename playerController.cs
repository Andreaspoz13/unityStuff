
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    public float horizontalInput;
    public float playerSpeed = 21.09f;
    public float verticalInput;
    public float xPositionOffset = -10.0f;
    public float zPositionOffset;
    public float xPositionOffsetZ = 0.0f;
    public float xPositionOffsetRight = 10.0f;
    public float zPositionOffsetBack = -1.3f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal"); 
       verticalInput = Input.GetAxis("Vertical");
       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);
       

       if(transform.position.x < -10) {
        transform.position = new Vector3(xPositionOffset, transform.position.y, transform.position.z);

       }

       if (transform.position.z > zPositionOffset) {
            transform.position = new Vector3(xPositionOffsetZ, transform.position.y, zPositionOffset);

       }
       if (transform.position.x > xPositionOffsetRight) {
        transform.position = new Vector3(xPositionOffsetRight, transform.position.y, transform.position.z);
       }

       if(Input.GetKeyDown(KeyCode.Space)) {
            //launch the carrot(prefab) from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            
       }
       
    }
}
