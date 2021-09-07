using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Comet : MonoBehaviour
{
    [SerializeField]
    private float SpeedRotationComet;
    private int direction;
    [SerializeField]
    private GameObject[] Comets;
    int Index;
    void OnEnable()
    {
        int value = Random.Range(0, 2);
        switch (value)
        {
            case 0:
                direction = +1;
                break;
            case 1:
                direction = -1;
                break;
        }
    }
    void Update()
    {
        transform.Rotate(0, 0, direction * SpeedRotationComet * Time.deltaTime);
        Index = 0;
        foreach (GameObject Obj in Comets)
        {
            if (Obj.activeSelf)
            {
                Index++;
            }
        }
        if(Index == 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Rum" && Comets[0].activeSelf == true)
        {
            Destroy(gameObject);
        }
        if (other.tag == "Bullet" )
        {
            Destroy(other.gameObject);
            for(int i = 0; i < 3; i++)
            {
                Comets[i].SetActive(true);
            }
            Comets[3].SetActive(false);
        }
        if (other.tag == "Laser")
        {
            Destroy(gameObject);
        }
    }
}
