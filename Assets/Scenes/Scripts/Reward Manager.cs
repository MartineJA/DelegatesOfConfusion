using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class RewardManager : MonoBehaviour
{
    //public delegate void attaqueBonus(ProjectileObject projectile, int dégâts);
    public UnityEvent attaqueBonus;

    //public static event attaqueBonus attaqueDouble;
    //public static event attaqueBonus attaqueExplosive;

    public ProjectileObject projectileDouble;
    public ProjectileObject projectileExplosive;


    private void Start()
    {
        attaqueBonus.Invoke();
    }
    public void ChoixDouble()
    {
        Debug.Log("choix 1");
        projectileDouble.dégâts = 3;
    }

    public void ChoixExplosive()
    {
        Debug.Log("choix 2");
        projectileExplosive.dégâts *= 3;
        
    }


}
