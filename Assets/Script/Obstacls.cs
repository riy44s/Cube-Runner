using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacls : MonoBehaviour
{
    public Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        rd.AddForce(-transform.forward *2500f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Obstacls")
        {
            Debug.Log("You lose");
        }
    }

}
