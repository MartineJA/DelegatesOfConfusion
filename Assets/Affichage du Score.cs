using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AffichageduScore : MonoBehaviour
{

    
    private TextMeshProUGUI texte;

    [SerializeField]
    private ProjectileObject score;

    // Start is called before the first frame update
    void Awake()
    {
        texte = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        texte.text = score.score.ToString();
    }
}
