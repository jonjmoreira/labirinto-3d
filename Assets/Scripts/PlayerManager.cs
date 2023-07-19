using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody playerRB;

    private float movementX, movementY, movementZ;
    private bool moveForward, moveBack, moveLeft, moveRight;
    public int speed;

    void Start()
    {
        speed = 50;
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer() 
    {
        moveForward = Input.GetKey(KeyCode.W);
        moveBack = Input.GetKey(KeyCode.S);
        moveLeft = Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.D);

        if (moveForward) {
            Player.transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (moveBack) {
            Player.transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (moveLeft) {
            Player.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (moveRight) {
            Player.transform.position += Vector3.right * speed * Time.deltaTime;
        }

        // movementX = Input.GetAxis("Horizontal") * speed;
        // movementZ = Input.GetAxis("Vertical") * speed;

        // playerRB.AddForce(movementX, 0f, movementZ);
    }
}
