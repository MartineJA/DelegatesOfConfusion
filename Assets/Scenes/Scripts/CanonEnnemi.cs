using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonEnnemi : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Eventmanager.gagn�OuPerdu += Choix;
    }


    void OnDisable()
    {
        Eventmanager.gagn�OuPerdu -= Choix;
    }



    public void Choix()
    {
        Debug.Log("CHOISIR ENTRE DEUX OPTIONS");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Touch� Coul�");
        }

    }

}
