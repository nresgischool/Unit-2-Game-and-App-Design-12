using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAutoDelete : MonoBehaviour
{
    public float timeLeft;
    MeshCollider wallCollider;
    // Start is called before the first frame update
    void Start()
    {
        // Sets wallCollider to selected walls Mesh Collider
        wallCollider = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        // Updates the timeLeft by unitys built in timer
        timeLeft -= Time.deltaTime;
        // When timeLeft is under 0 disable the walls Mesh Collider
        if(timeLeft < 0)
        {
            wallCollider.enabled = false;
        }
    }
}
