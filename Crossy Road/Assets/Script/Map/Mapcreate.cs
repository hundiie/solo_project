using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapcreate : MonoBehaviour
{
    public GameObject[] Map = new GameObject[5];
    public GameObject SP;
    public float bestscore;
    public bool flag;

    private int see;
    private int random;
    private float inmap;
    private float startmapdata = 5.0f;
    private void Start()
    {
        flag = false;
        for (int i = 0; i < 10; i++)
        {
            random = Random.Range(0, 101);

            if (0 < random && random <= 10)
            {
                random = 0;  
            }
            else if (10 < random && random <= 20)
            {
                random = 1;
            }
            else if (20 < random && random <= 40)
            {
                random = 2;
            }
            else if (40 < random && random <= 70)
            {
                random = 3;
            }
            else if (70 < random && random <= 100)
            {
                random = 4;
            }

            Vector3 startmap = new Vector3(0, -0.5f, startmapdata);
            if (Map[random].tag == "water")
            {
                startmap = new Vector3(0, -1, startmapdata);
            }
            randomcreat(random,startmap);
            startmapdata += 1.0f;

        }
    }
    void Update()
    {
        if (flag)
        {
            random = Random.Range(0, 101);
            if (0 < random && random <= 10)
            {
                random = 0;
            }
            else if (10 < random && random <= 15)
            {
                random = 1;
            }
            else if (15 < random && random <= 20)
            {
                random = 2;
            }
            else if (20 < random && random <= 60)
            {
                random = 3;
            }
            else if (60 < random && random <= 100)
            {
                random = 4;
            }
            inmap = bestscore + 14.0f;
            Vector3 mapp = new Vector3(0, -0.5f, inmap);
            if (Map[random].tag == "water")
            {
                mapp = new Vector3(0, -1, inmap);
            }
            randomcreat(random,mapp);
            flag = false;
        }
    }
    private void randomcreat(int rnum , Vector3 mapp)
    {
        Instantiate(Map[rnum], mapp, transform.rotation = Quaternion.Euler(0, 0, 0));
    }
}
