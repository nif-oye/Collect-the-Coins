using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 7;
    public float steerSpeed = 200;
    public Vector3 playerPosition;
    public Quaternion playerRotation;
    void Start()
    {
        
    }

    void Update()
    {
        movePlayer();
        steerPlayer();

        playerPosition = transform.position;
        playerRotation = transform.rotation;
    }

    void movePlayer(){
        float moveX = Input.GetAxis("Vertical") * -moveSpeed * Time.deltaTime;
        transform.Translate(moveX, 0, 0);
    }

    void steerPlayer(){
        float steer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        transform.Rotate(0, steer, 0);
    }
}
