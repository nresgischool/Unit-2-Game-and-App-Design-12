using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDoors : MonoBehaviour
{
    public GameObject door;
    public Vector3 originalPosition;
    public Color colour;

    // Moves the door to "open" it when the cube is placed on
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Trigger")
        {
            door.transform.position = new Vector3(5, 0, 0);
            ChangeMyColor();
        }
    }
    // Moves the door back to its original position when the cube is removed off the plate
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Trigger")
        {
            gameObject.GetComponent<Renderer>().material.color = colour;
            door.transform.position = originalPosition;
        }
    }

    void ChangeMyColor()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
