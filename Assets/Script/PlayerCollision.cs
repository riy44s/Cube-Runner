using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player movement;
   
   void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.tag == "Obstracls")
        {
            movement.enabled = false;
            FindObjectOfType<GameManeger>().EndGame();
          
        }
    }

}
 