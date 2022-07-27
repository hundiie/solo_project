using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_log : MonoBehaviour
{
    private float randomf;
    private float timef;
    private int firstlog;
    private int see;

    public GameObject[] log = new GameObject[3];
    private void Start()
    {
        see = Random.Range(0, 2);
        firstlog = Random.Range(0,3);
        randomf = Random.Range(0,2);
    }

    void Update()
    {
        timef += Time.deltaTime;
        Vector3 logmake = this.transform.position;
        switch (see)
        {
            case 0:
                logmake.x = transform.forward.x + 10;
                break;
            case 1:
                logmake.x = transform.forward.x - 10;
                break;
            default:
                break;
        }
        logmake.y += 0.5f;
        if (timef >= randomf)
        {
            randomf = Random.Range(2, 5);
            switch (see)
            {
                case 0:
                    Instantiate(log[firstlog], logmake, transform.rotation = Quaternion.Euler(0, 180, 0));
                    break;
                case 1:
                    Instantiate(log[firstlog], logmake, transform.rotation);
                    break;
                default:
                    break;
            }
            
            timef = 0.0f;
        }
        
    }
}
