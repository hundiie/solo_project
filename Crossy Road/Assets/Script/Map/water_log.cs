using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_log : MonoBehaviour
{
    private float randomf;
    private float timef;

    public GameObject log;
    private void Start()
    {
        randomf = Random.Range(2,5);
    }

    void Update()
    {
        timef += Time.deltaTime;
        Vector3 logmake = this.transform.position;

        logmake.x += -10.0f;
        logmake.y += 0.5f;
        if (timef >= randomf)
        {
            randomf = Random.Range(2, 5);
            Instantiate(log, logmake, transform.rotation);
            timef = 0.0f;
        }
        
    }
}
