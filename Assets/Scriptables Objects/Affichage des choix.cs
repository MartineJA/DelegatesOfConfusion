using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Affichagedeschoix : MonoBehaviour
{

    public EnnemiObject ennemiObject;
    // Start is called before the first frame update

    private void Start()
    {
        
    }


    private void OnEnable()
    { 
        Eventmanager.gagn�OuPerdu += ChoicetoMake;
        
    }

    private void OnDisable()
    {
        Eventmanager.gagn�OuPerdu -= ChoicetoMake; 

    }

    void ChoicetoMake()
    {
        Debug.Log("choisir entre deux boutons");
    }
}
