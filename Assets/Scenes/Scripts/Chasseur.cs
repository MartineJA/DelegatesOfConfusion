using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Chasseur : MonoBehaviour
{

    public Transform playerTransform;
    private Rigidbody2D rGB;

    public float speed = 5f;

    private void Awake()
    {
        rGB = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //playerTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame


    private void FixedUpdate()
    {
        //rGB.velocity = transform.forward * speed;
        Vector2 direction = playerTransform.position - transform.position;

        Quaternion rotation = Quaternion.LookRotation(direction * Time.fixedDeltaTime);
        rGB.MoveRotation(rotation);
    }
}
