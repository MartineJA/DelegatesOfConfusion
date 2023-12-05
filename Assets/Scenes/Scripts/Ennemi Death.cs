using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiDeath : MonoBehaviour
{
    // Start is called before the first frame update
  
    public delegate void EnnemiMort ();
    public static event EnnemiMort onMort;

    [SerializeField]
    private EnnemiObject m_Object;

    void Baston()
    {
        if (m_Object.score == 3)      
        { if (onMort != null) onMort(); }
    }


}
