using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveCount = 1.0f;
    public float speedddd;

    private float playerX = 0;
    private float playerY = 0;

    private float moveHorizontal;
    private float moveVertical;
    
    private int score;
    private int bestScore;
    
    private Vector3 movement;
    private Vector3 MyMovement;
    private Vector3 MYvector;
    
    private float movementSpeed = 0.05f;
    private float sumN;

    private bool nextmove;
    private bool movewall;
    private int COUNT;

    private Rigidbody RB;
    private Mapcreate mapc;
    private PlayerState playst;
    
    private void Start()
    {
        nextmove = true;
        movewall = true;
        score = 0;
        bestScore = 0;

        playerX = 0;
        playerY = 0;
        
        moveHorizontal = 0;
        moveVertical = 0;
        
        sumN = 0f;
        
        RB = GetComponent<Rigidbody>();
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
        Debug.Log($"my movement{ MyMovement}");
        movement = new Vector3(playerX, 0.0f, playerY);
        if (nextmove)
        {
            moveHorizontal = 0;
            moveVertical = 0;

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveVertical = 1;
                playerY++;
                score++;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                nextmove = false;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveVertical = -1;
                playerY--;
                score--;
                transform.rotation = Quaternion.Euler(0, 180, 0);
                nextmove = false;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveHorizontal = 1;
                playerX++;
                transform.rotation = Quaternion.Euler(0, 90, 0);
                nextmove = false;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveHorizontal = -1;
                playerX--;
                transform.rotation = Quaternion.Euler(0, 270, 0); 
                nextmove = false;
            }
            COUNT = 20;
        }
            
        if (!nextmove)
        {
            if (COUNT != 0)
            {
                MYvector = this.transform.position;
                MYvector += new Vector3(moveHorizontal * movementSpeed, Mathf.Sin(0.01f), moveVertical * movementSpeed);
                transform.position = MYvector;
                COUNT--;
            }
            else
            {
                RB.AddForce(0, -10, 0);
                movement = new Vector3(playerX, 0.0f, playerY);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NOMAL" || collision.gameObject.tag == "log")
        {
            MyMovement = this.transform.position;
            nextmove = true;
            transform.position = movement;
        }
        if (collision.gameObject.tag == "wall")
        {
            COUNT = 0;
            transform.position = MyMovement;
            movement = MyMovement;


        }
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.tag);
        
        if (other.tag == "log")
        {
            Vector3 movelog = this.transform.position;
            if (other.transform.rotation.y == 0)
            {
                movelog.x += speedddd;
                sumN += speedddd;
                if (sumN >= 1.0f)
                {
                    sumN -= 1.0f;
                    playerX += 1.0f;
                }
            }
            else
            {
                movelog.x -= speedddd;
                sumN += speedddd;
                if (sumN >= 1.0f)
                {
                    sumN -= 1.0f;
                    playerX -= 1.0f;
                }
            }
            this.transform.position = movelog;
        }
    }
}
