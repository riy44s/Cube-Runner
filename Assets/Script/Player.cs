using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rd;
    public float FrontForwardForce= 2000f;
    public float SideForward = 500f;
    public bool isjumb;
    public bool isground;
  
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
            rd.AddForce(0, 0, FrontForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rd.AddForce(SideForward*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rd.AddForce(-SideForward*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (rd.position.y < -1f)
        {
            FindObjectOfType<GameManeger>().EndGame();
          
        }
      

        if (isground==false)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isjumb=true;
        }
        

    }

    public void FixedUpdate()
    {
        if (isjumb)
        {
            rd.AddForce(Vector3.up * 5.5f, ForceMode.VelocityChange);
            isjumb = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        isground=true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isground = false;
    }
}
