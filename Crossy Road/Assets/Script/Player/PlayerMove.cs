using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveCount = 1.0f;
    public float movementSpeed = 1.0f;
    public int jumpPower;
    public float speedddd;
    private int score;
    private int bestScore;
    private Vector3 movement;
    private Vector3 MYvector;
    private bool nextmove;
    private float moveHorizontal;
    private float moveVertical;
    private Rigidbody RB;
    private int COUNT;

    private Mapcreate mapc;
    private PlayerState playst;
    private void Start()
    {
        RB = GetComponent<Rigidbody>();
        moveHorizontal = 0;
        moveVertical = 0;
        nextmove = true;
        score = 0;
        bestScore = 0;
        mapc = GetComponent<Mapcreate>();
        playst = GetComponent<PlayerState>();
    }
    void Update()
    {
        INPUT();

        if (score > bestScore)
        {
            bestScore = score;
            mapc.bestscore = bestScore;
            playst.bestscoree = bestScore;
            mapc.flag = true;
        }
    }

    private void INPUT()
    {
        if (nextmove == true)
        {
            moveHorizontal = 0;
            moveVertical = 0;

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveVertical = 1;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                MYvector = this.transform.position;
                MYvector.z += 1;
                //RB.AddForce(0, jumpPower, 0);
                nextmove = false;
                score++;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveVertical = -1;
                transform.rotation = Quaternion.Euler(0, 180, 0);
                MYvector = this.transform.position;
                MYvector.z += -1;
                //RB.AddForce(0, jumpPower, 0);
                nextmove = false;
                score--;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveHorizontal = 1;
                transform.rotation = Quaternion.Euler(0, 90, 0);
                MYvector = this.transform.position;
                MYvector.x += 1;
                //RB.AddForce(0, jumpPower, 0);
                nextmove = false; 
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveHorizontal = -1;
                transform.rotation = Quaternion.Euler(0, -90, 0); 
                MYvector = this.transform.position;
                MYvector.x += -1;
                //RB.AddForce(0, jumpPower, 0);
                nextmove = false; 
            }

            movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        }
        
        if (!nextmove)
        {
                transform.position = MYvector;
                nextmove = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        nextmove = true;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.tag);
        Vector3 movelog = this.transform.position;
        movelog.x += speedddd;
        if (other.tag == "log")
        {
            this.transform.position = movelog;
        }
    }
}
