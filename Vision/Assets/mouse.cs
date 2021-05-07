using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public float rotationSpeed = 90;
   


    public float moveSpeed = 3;
    public GroundCheckScript gc;

    public bool moving;
    public bool rotating1;
  
    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
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
            rb2D.velocity = transform.up * moveSpeed;
            rb2D.angularVelocity = 0;
        }
        else
        {
            rb2D.angularVelocity = rotationSpeed;
        }

    }
}
