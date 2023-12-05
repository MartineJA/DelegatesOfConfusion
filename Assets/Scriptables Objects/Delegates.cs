using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    public delegate void ChoixDelegate();
    public ChoixDelegate choix;

    public event ChoixDelegate callback;

    public EnnemiObject ennemi;

    // Start is called before the first frame update
    void Start()
    {
        choix += PremierChoix;
        choix += SecondChoix;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ennemi.score == 10)
        {
            INVOCATION();
        }
        if (callback != null) { callback(); }
    }

    void INVOCATION()
    {
            Debug.Log("event invoked");
            callback += PremierChoix;
            callback(); 
    }

    void PremierChoix()
    {   
        Debug.Log("premier choix");
    }

    void SecondChoix()
    {
        Debug.Log("second choix");
    }
}
