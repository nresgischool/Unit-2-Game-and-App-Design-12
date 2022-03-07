using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            // Instantiates the projectile infront of the player and launches it using the player set launchVelocity
            GameObject capsule = Instantiate(projectile, transform.position, transform.rotation);
            capsule.GetComponent<Rigidbody>().AddRelativeForce((new Vector3(0, 0, launchVelocity)));
        }
    }
}
