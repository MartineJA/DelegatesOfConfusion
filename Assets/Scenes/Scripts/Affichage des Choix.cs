using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichagedesChoix : MonoBehaviour
{

    Canvas canvas;
    public EnnemiObject ennemi;

    // Start is called before the first frame update
    void Start()
    {
       gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void EnableChoice()
    {
        EnnemiDeath.onMort += MakeChoice;
    }

    void MakeChoice()
    {
        gameObject.SetActive (true);

    }

}
