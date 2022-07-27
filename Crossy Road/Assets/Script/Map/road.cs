using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road : MonoBehaviour
{
    private float randomf;
    private float timef;
    private int rannum;
    private int see;

    public GameObject[] car = new GameObject[2];
    private void Start()
    {
        see = Random.Range(0, 2);
        randomf = Random.Range(2, 5);
        rannum = Random.Range(0, 2);
    }

    void Update()
    {
        timef += Time.deltaTime;
        Vector3 carmake = this.transform.position;
        switch (see)
        {
            case 0:carmake.x = transform.forward.x + 13;
                break;
            case 1: carmake.x = transform.forward.x - 13;
                break;
            default:
                break;
        }
        carmake.y += 1.0f;

        if (timef >= randomf)
        {
            randomf = Random.Range(2, 6);
            switch (see)
            {
                case 0:
                    Instantiate(car[rannum], carmake, transform.rotation = Quaternion.Euler(0,180,0));
                    break;
                case 1:
                    Instantiate(car[rannum], carmake, transform.rotation);
                    break;
                default:
                    break;
            }
            
            timef = 0.0f;
        }

    }
}
