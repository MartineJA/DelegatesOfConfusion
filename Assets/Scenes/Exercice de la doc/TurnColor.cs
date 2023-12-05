using UnityEngine;
using System.Collections;

public class TurnColor : MonoBehaviour
{
    void OnEnable()
    {
        OnClick.OnClicked += ColorChange;
    }


    void OnDisable()
    {
        OnClick.OnClicked -= ColorChange;
    }


    void ColorChange()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        //renderer.material.color = col;
    }
}
