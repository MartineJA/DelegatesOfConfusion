using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ennemi : MonoBehaviour
{
    [SerializeField]
    private EnnemiObject ennemi;

    [SerializeField]
    private GameObject bonus;

    /*
    [SerializeField]
    private GameObject ennemiType001;
    [SerializeField]
    private GameObject ennemiType002;

    
    [SerializeField]
    private GameObject ennemiType003;

    [SerializeField]
    private GameObject ennemiType004;

    [SerializeField]
    private GameObject ennemiType005;*/


    public float speed = 10f;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ennemiType001.transform.position = Vector2.left * Time.deltaTime;
        //ennemiType002.transform.Rotate(0,0,360 * Time.deltaTime * speed);


     
    }




    private void OnParticleCollision(GameObject other)
    {

        // si un projectile du joueur touche un ennemi, l'ennemi disparait et le score du joueur augmente de 1
    
            Destroy(gameObject);
            //Destroy(other);
            ennemi.score++;
            Debug.Log("Hit");
            Instantiate(bonus);
        
           

    }
}
