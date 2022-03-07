using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePortal : MonoBehaviour
{
    public Color colour;

    void OnCollisionEnter(Collision col)
    {
        // Enables the isTrigger on the portal to allow the player to interact with TeleportPlayer
        if (col.gameObject.tag == "Portal")
        {
            col.gameObject.GetComponent<Renderer>().material.color = colour;
            col.transform.GetComponent<Collider>().isTrigger = true;
        }
    }
}
