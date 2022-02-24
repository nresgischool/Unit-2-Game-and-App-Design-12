using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherObjectDestroyer : MonoBehaviour
{
    public GameObject destroy;
    /*private void OnControllerColliderHit(ControllerColliderHit other)
    {
        if(other.gameObject.tag == "Trigger")
        {
            Destroy(destroy);
            Debug.Log("hit");
        }
    }*/
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Trigger")
        {
            Debug.Log("Collision ");
            Destroy(destroy);
            ChangeMyColor();
        }
    }
    void ChangeMyColor()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}


