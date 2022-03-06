using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabAutoDelete : MonoBehaviour
{
    public float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        // Destroys the prefab when its lifeTime runs out
        Destroy(gameObject, lifeTime);
    }
}
