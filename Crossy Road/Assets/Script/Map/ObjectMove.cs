using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float speed = 0.1f;

    void Update()
    {
        transform.Translate(speed, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "deleteZone")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.Translate(speed*Time.deltaTime, 0, 0);
        }
    }
}
