using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapdestroy : MonoBehaviour
{
    private float myz;
    private Vector3 cameravector;
    
    public float cameravew;
    private Camera CAME;

    private void Start()
    {
        CAME = Camera.main;
        cameravector = CAME.transform.position;
        cameravector.z += cameravew;
    }

    private void Update()
    {
        if (cameravector.z < CAME.transform.position.z)
        {
            Destroy(gameObject);
        }
    }


}
