using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Eventmanager : MonoBehaviour
{
    public delegate void GagneOuPerd();
    public static event GagneOuPerd gagnéOuPerdu;

    public EnnemiObject ennemi;
    
   /*void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            if (gagnéOuPerdu != null)
                gagnéOuPerdu();
        }
    }*/

 
    void isDead()
    {
        if (gagnéOuPerdu != null)
            gagnéOuPerdu();
    }








}
