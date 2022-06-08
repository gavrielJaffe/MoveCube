using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public PlayerMovement movement ;
    void OnCollisionEnter (Collision collisionInfo)
    {
        // Collision collisionInfo
        if (collisionInfo.collider.tag == "obstacle"){
            movement.enabled = false;
        }
    }    
}
