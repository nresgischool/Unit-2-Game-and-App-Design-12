using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherObjectDestroyer : MonoBehaviour
{
    public GameObject destroy;

    //Destroy and object if two unrelated objects come in contact
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Trigger")
        {
            Debug.Log("Collision ");
            Destroy(destroy);
            ChangeMyColor();
        }
    }
    //Changes the color of the object that come in contact because why not
    void ChangeMyColor()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}


