using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer : MonoBehaviour
{

    [SerializeField]
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void LateUpdate()
    {

        Vector3 cameraPos = new Vector3(target.position.x, target.position.y, -10f);
        Vector3 newPosition = Vector3.Lerp(transform.position, cameraPos, 15f*Time.deltaTime);
        transform.position = cameraPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
