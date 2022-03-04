using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            GameObject capsule = Instantiate(projectile, transform.position, transform.rotation);
            capsule.GetComponent<Rigidbody>().AddRelativeForce((new Vector3(0, 0, launchVelocity)));
        }
    }
}
