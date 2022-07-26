using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class train : MonoBehaviour
{
    private float randomf;
    private float timef;

    public GameObject Train;
    private void Start()
    {
        randomf = Random.Range(2, 5);
    }

    void Update()
    {
        timef += Time.deltaTime;
        Vector3 logmake = this.transform.position;

        logmake.x += -20.0f;
        logmake.y += 1.0f;
        if (timef >= randomf)
        {
            randomf = Random.Range(10, 20);
            Instantiate(Train, logmake, transform.rotation);
            timef = 0.0f;
        }
    }
}
