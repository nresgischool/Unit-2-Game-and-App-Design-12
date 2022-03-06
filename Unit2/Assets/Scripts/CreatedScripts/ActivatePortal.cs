using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePortal : MonoBehaviour
{
    public GameObject teleporter;
    public Color colour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Trigger")
        {
            teleporter.GetComponent<Renderer>().material.color = colour;
            teleporter.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
