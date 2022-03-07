using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePortal : MonoBehaviour
{
    public Color colour;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Portal")
        {
            col.gameObject.GetComponent<Renderer>().material.color = colour;
            col.transform.GetComponent<Collider>().isTrigger = true;
        }
    }
}
