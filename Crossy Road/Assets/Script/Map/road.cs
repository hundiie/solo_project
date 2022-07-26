using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road : MonoBehaviour
{
    private float randomf;
    private float timef;

    public GameObject car;
    private void Start()
    {
        randomf = Random.Range(2, 5);
    }

    void Update()
    {
        timef += Time.deltaTime;
        Vector3 logmake = this.transform.position;

        logmake.x += -10.0f;
        logmake.y += 1.0f;
        if (timef >= randomf)
        {
            randomf = Random.Range(2, 4);
            Instantiate(car, logmake, transform.rotation);
            timef = 0.0f;
        }

    }
}
