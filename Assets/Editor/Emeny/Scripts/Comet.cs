using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Comet : MonoBehaviour
{
    [SerializeField]
    private float SpeedRotationComet;
    private int direction;
    void OnEnable()
    {
        int value = Random.Range(1, 2);
        Debug.Log(value);
        switch (value)
        {
            case 1:
                direction = +1;
                break;
            case 2:
                direction = -1;
                break;
        }
    }
    void Update()
    {
        transform.Rotate(0, 0, direction * SpeedRotationComet * Time.deltaTime); ;
    }
}
