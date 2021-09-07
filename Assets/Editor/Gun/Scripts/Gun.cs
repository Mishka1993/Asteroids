using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject Laser;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Laser.activeSelf == false)
        {
            Instantiate(bullet, transform.position, transform.rotation, transform.parent);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Laser.SetActive(true);
        }
    }
}
