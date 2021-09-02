using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D Spaceship;
    [SerializeField]
    private float Speed = 20f;
    [SerializeField]
    private float SpeedRotation = 10f;

    void Start()
    {
        Spaceship = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            Spaceship.AddForce(transform.up * Speed);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 0, SpeedRotation * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, -SpeedRotation * Time.deltaTime);
        }


        if (transform.localPosition.y > 623.5f)
        {
            transform.localPosition = new Vector3(-transform.localPosition.x, -623.5f, 0f);
        }else if (transform.localPosition.y < -623.5f)
        {
            transform.localPosition = new Vector3(-transform.localPosition.x, 623.5f, 0f);
        }

        if (transform.localPosition.x > 1054f)
        {
            transform.localPosition = new Vector3(-1054f, -transform.localPosition.y, 0f);
        }
        else if (transform.localPosition.x < -1054f)
        {
            transform.localPosition = new Vector3(1054f, -transform.localPosition.y, 0f);
        }
    }
}