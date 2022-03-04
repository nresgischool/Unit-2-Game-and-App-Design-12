using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallWarp : MonoBehaviour
{
    public GameObject warpPoint;
    public GameObject warpPoint2;
    public float teleportFloorLevel;
    public bool spawnNew = false;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= teleportFloorLevel)
        {
            CharacterController controller = GetComponent<CharacterController>();

            if (controller != null && spawnNew == true)
            {
                controller.enabled = false;
                controller.transform.position = warpPoint2.transform.position;
                controller.enabled = true;
            }
            else if (controller != null)
            {
                controller.enabled = false;
                controller.transform.position = warpPoint.transform.position;
                controller.enabled = true;
            }

        }
    }
    // Detect collision with the SpawnTrigger tag to set a new spawnpoint
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "SpawnTrigger")
        {
            Debug.Log("nwe spawn");
            spawnNew = true;
        }    
    }
}
