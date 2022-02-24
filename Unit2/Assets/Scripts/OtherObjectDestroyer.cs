using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherObjectDestroyer : MonoBehaviour
{
    public GameObject destroy;
    private void OnControllerColliderHit(ControllerColliderHit other)
    {
        if(other.gameObject.tag == "Trigger")
        {
            Destroy(destroy);
            Debug.Log("hit");
        }
    }
}


