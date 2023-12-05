using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform projectileOrigin;

    float fireRate = 0.3f;
    float nextFire = 0f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            {
            if (Time.time > nextFire)
            {

                nextFire = Time.time + fireRate;
                GameObject projectileClone = Object.Instantiate(projectile);

                projectileClone.transform.parent = projectileOrigin;
                projectileClone.transform.localPosition = Vector3.zero;
                projectileClone.transform.rotation = transform.rotation;

            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ennemi"))
        {
            Debug.Log("Collision");
        }
    }


}
