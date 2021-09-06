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
        float VerticalActive = Input.GetAxis("Vertical");
        if (VerticalActive > 0.1)
        {
            Spaceship.AddForce(transform.up * Speed);
        }      
       
        float HorizontalActive = Input.GetAxis("Horizontal");
        transform.Rotate(0f, 0f, HorizontalActive * SpeedRotation * Time.deltaTime);


        if (transform.localPosition.y > 623.5f)
        {
            transform.localPosition = new Vector3(-transform.localPosition.x, -623.5f, 0f);
        }
        else if (transform.localPosition.y < -623.5f)
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