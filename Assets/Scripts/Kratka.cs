using System.Collections;
using System.Collections.Generic;
using UnityEngine;



enum Wybrane
{
    KRZYZYK,
    KOLKO
}

public class Kratka : MonoBehaviour
{
    public Sprite kolko, krzyzyk;

    Wybrane Wybor = Wybrane.KOLKO;
    

    SpriteRenderer sr;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        Debug.Log("klik klik :)");

        sr.sprite = kolko;

        if (Wybor == Wybrane.KOLKO)
        {
            sr.sprite = krzyzyk;
            Wybrane = Wybrane.KRZYZYK;
        }
        else
        {
            sr.sprite = kolko;
        }
    }
}
