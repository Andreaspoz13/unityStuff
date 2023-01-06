
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
        public Rigidbody rigidBody;
        public float resetPosition = 500f;

         public Movement movement;
         void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle"){
            Debug.Log("You hit an obstacle!!");
            
            movement.enabled = false;

            transform.Translate(-0.57f, 1.16f, -0.02f);

            
            rigidBody.AddForce(-resetPosition, 0, 0);
            

        }
    }
}
