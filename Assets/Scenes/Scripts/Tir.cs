using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour
{
    [SerializeField]
    private EnnemiObject ennemi;
    // CE SCRIPT TUE LE PLAYER QUAND IL ENTRE EN CONTACT AVEC UN ENNEMI


    private void OnCollisionEnter2D(Collision2D collision)
  
    {
        Destroy(gameObject);
        // endgame event
        // end camera
        // print end screen
        // choices :  recommencer ou quitter
        Debug.Log("fin de partie");

    }
}
