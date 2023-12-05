using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rGB;
    private Vector2 direction;

    public float speed;

    // Start is called before the first frame update
    void Awake()
    {
        rGB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * speed;
        direction.y = Input.GetAxis("Vertical") * speed;

        //Quaternion rotation = Quaternion.LookRotation(direction); 
        //rGB.MoveRotation(rotation);

    }
    private void FixedUpdate()
    {
        rGB.velocity = direction;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Bullet"))
        {
            //
        }
    }
}
