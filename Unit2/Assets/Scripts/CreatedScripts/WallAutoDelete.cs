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
        wallCollider = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0)
        {
        wallCollider.enabled = false;
        }
    }
}
