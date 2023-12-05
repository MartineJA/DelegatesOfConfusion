using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiShoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform projectileOrigin;

    public float fireRate = 5f;
    float nextFire = 0f;

    public int cloneNb = 0;

    public EnnemiObject ennemi;
    public ParticleSystem superAttack;

    private void Update()
    {
    
            if (Time.time > nextFire)
            {

                nextFire = Time.time + fireRate;
                GameObject projectileClone = Object.Instantiate(projectile);
                cloneNb++;

                projectileClone.transform.parent = projectileOrigin;
                projectileClone.transform.localPosition = Vector3.zero;
                projectileClone.transform.rotation = transform.rotation;

            }

            if(cloneNb == 3)
            {

            Debug.Log("super attaque");
            superAttack.Play();

            cloneNb = 0;

            }

    
        
        
    }

}
