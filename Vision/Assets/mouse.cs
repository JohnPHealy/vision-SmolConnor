using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public float rotateSpeed = -90;
    public float rotateSpeed2 = -90;
    public float moveSpeed = -3;
    public GroundCheckScript gc;
    public Ground2check gc2;
    public bool moving;
    public bool rotating1;
    public bool rotating2;
    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gc.Grounded == true)
        {
            
            moving = false;
            rotating1 = true;
        }
        else if (gc.Grounded == false)
        {
            moving = true;
            rotating1 = false;
        }
        if (moving == true)
        {
            rigidbody2D.velocity = transform.up * moveSpeed;
            rigidbody2D.angularVelocity = 0;
        }
        if (rotating1 == true)
        {
            rigidbody2D.angularVelocity = rotateSpeed;
        }

        if (gc2.Grounded2 == true)
        {

            moving = false;
            rotating2 = true;
        }
        else if (gc2.Grounded2 == false)
        {
            moving = true;
            rotating2 = false;
        }
        if (moving == true)
        {
            rigidbody2D.velocity = transform.up * moveSpeed;
            rigidbody2D.angularVelocity = 0;
        }
        if (rotating2 == true)
        {
            rigidbody2D.angularVelocity = rotateSpeed2;
        }
    }
}
