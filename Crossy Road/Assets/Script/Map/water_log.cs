using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_log : MonoBehaviour
{
    private float randomf;
    private float timef;
    private int firstlog;
    public GameObject[] log = new GameObject[3];
    private void Start()
    {
        firstlog = Random.Range(0, 3);
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
            randomf = Random.Range(2, 4);
            Instantiate(log[firstlog], logmake, transform.rotation);
            timef = 0.0f;
        }
        
    }
}
