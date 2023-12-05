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
        Eventmanager.gagnéOuPerdu += ChoicetoMake;
        
    }

    private void OnDisable()
    {
        Eventmanager.gagnéOuPerdu -= ChoicetoMake; 

    }

    void ChoicetoMake()
    {
        Debug.Log("choisir entre deux boutons");
    }
}
