using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class train : MonoBehaviour
{
    private float randomf;
    private float timef;
    private int see;

    public GameObject Train;
    public GameObject Siren;

    private bool button = false;
    private void Start()
    {
        randomf = Random.Range(1, 10);
        see = Random.Range(0, 2);
    }

    private void Update()
    {
        timef += Time.deltaTime;
        Vector3 trainmake = this.transform.position;
        switch (see)
        {
            case 0:
                trainmake.x = transform.forward.x + 15;
                break;
            case 1:
                trainmake.x = transform.forward.x - 15;
                break;
            default:
                break;
        }
        trainmake.y += 1.0f;
        
        Vector3 sirenmake = this.transform.position;
        sirenmake.x += -5.0f;
        sirenmake.y += 3.0f;
        if (timef >= randomf - 3.0f && !button)
        {
            for (int i = 0; i < 3; i++)
            {
                Instantiate(Siren, sirenmake, transform.rotation);
                sirenmake.x += 5.0f;
            }
            button = true;
        }

        if (timef >= randomf)
        {
            randomf = Random.Range(5, 10);
            switch (see)
            {
                case 0:
                    Instantiate(Train, trainmake, transform.rotation = Quaternion.Euler(0, 180, 0));
                    break;
                case 1:
                    Instantiate(Train, trainmake, transform.rotation);
                    break;
                default:
                    break;
            }
            timef = 0.0f;
            button = false;
        }
    }
}
