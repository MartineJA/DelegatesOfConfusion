using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rGB;
    private Vector2 direction;

    // Start is called before the first frame update
    void Awake()
    {
        rGB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rGB.velocity = direction;
    }
}
