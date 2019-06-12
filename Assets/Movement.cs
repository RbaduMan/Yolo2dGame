using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;

    private float t = 0.0f;
    private bool moving = false;

    void Awake()
    {
        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }
    void Start()
    {
        gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
    }

    void FixedUpdate() {

    }

    // Update is called once per frame
    void Update()
    {
        //Press the Up arrow key to move the RigidBody upwards
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //rb.velocity = new Vector2(0.0f, 2.0f);
            rb.AddForce(new Vector2(5, 5), ForceMode2D.Impulse);
            moving = true;
            t = 0.0f;
        }

        //Press the Down arrow key to move the RigidBody downwards
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0.0f, -1.0f);
            moving = true;
            t = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-3.0f, 0.0f);
            moving = true;
            t = 0.0f;
        }

        //Press the Down arrow key to move the RigidBody downwards
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(3.0f, 0.0f);
            moving = true;
            t = 0.0f;
        }

         if (Input.GetMouseButtonDown(0)) 
             {
                 Debug.Log("Tranfrom pos" + transform.position);
                 Vector2 clickPosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                 //this.gameObject.transform.position = clickPosition;
                 rb.AddForce(clickPosition * 100);
                 
             }

    }

     void OnMouseDown()
    {

        //this.gameObject.transform.position = new Vector2(gameObject.transform.position.x + 0.25f, gameObject.transform.position.y);
        //this.gameObject.velocity = (transform.forward * vertical) * speed * Time.fixedDeltaTime;
    }
}
