using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject Player;
    public Camera Camera;
    private bool moveForward, moveBack, moveLeft, moveRight;
    public float speed;

    void Start()
    {
        speed = 200;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    public void MoveCamera()
    {

        float mouseX = (Input.mousePosition.x / Screen.width ) - 0.5f;
        float mouseY = (Input.mousePosition.y / Screen.height ) - 0.5f;

        transform.localRotation = Quaternion.Euler(new Vector4(-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));

        // this.transform.position = new Vector3(
        //     Player.transform.position.x,
        //     Player.transform.position.y + 5,
        //     Player.transform.position.z
        // );

        moveForward = Input.GetKey(KeyCode.W);
        moveBack = Input.GetKey(KeyCode.S);
        moveLeft = Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.D);

        if (moveForward) {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (moveBack) {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        if (moveLeft) {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        if (moveRight) {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }
}
