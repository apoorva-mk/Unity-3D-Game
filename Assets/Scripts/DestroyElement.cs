using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyElement : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeToDestroy = 2f;
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }

}
