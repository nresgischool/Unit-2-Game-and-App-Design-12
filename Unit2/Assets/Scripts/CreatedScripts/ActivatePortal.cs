using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePortal : MonoBehaviour
{
    //public GameObject teleporter;
    public Color colour;
    Collider obCollider;
    // Start is called before the first frame update
    void Start()
    {

        //obCollider = gameObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Trigger")
        {
            col.gameObject.GetComponent<Renderer>().material.color = colour;
            col.gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }*/
    void OnTriggerEnter(Collider col)
    {
        obCollider = gameObject.GetComponent<Collider>();
        if (col.gameObject.tag == "Trigger")
        {
            col.gameObject.GetComponent<Renderer>().material.color = colour;
            //col.gameObject.GetComponent<BoxCollider>().enabled = true;
            col.transform.collider.isTrigger = true;
        }
    }
}
