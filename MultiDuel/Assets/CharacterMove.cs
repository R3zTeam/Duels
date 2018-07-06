using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {
    public float moveSpeed;
    public float maxSpeed;


    private Vector3 spawnpoint;

    private Vector3 userInput;

    float delaytime = 1.0f;

    void Start()
    {

        moveSpeed = 50;
        maxSpeed = 15f;

        spawnpoint = transform.position;
    }

    void Update()
    {


        if (delaytime >= 0)
        {

            delaytime -= Time.deltaTime;
            return;

        }
        else
        {

            userInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

            if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
            {

                GetComponent<Rigidbody>().AddForce(userInput * moveSpeed);
            }

            Vector3 facingrotation = Vector3.Normalize(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));

            if (facingrotation != Vector3.zero)
            {

                transform.forward = facingrotation;
            }
        }
    }
}
