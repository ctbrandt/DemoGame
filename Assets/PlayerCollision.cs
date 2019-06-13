using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    // Update is called once per frame
    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle"){
            Debug.Log(collisionInfo.collider.name);
        }
    }
}
