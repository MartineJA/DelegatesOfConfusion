using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Eventmanager;

public class OnCollisionDestroy : MonoBehaviour
{
    [SerializeField] EnnemiObject ennemi;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ennemi")
        {
            Destroy(collision.gameObject);
            ennemi.score += 1;

            if(ennemi.score > 0)
            {
                //
            }
            
            
        }
    }
}
