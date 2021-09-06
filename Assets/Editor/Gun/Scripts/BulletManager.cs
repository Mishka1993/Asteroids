using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField]
    private float SpeedBullet;

    private void Update()
    {
        transform.Translate(Vector2.up * SpeedBullet * Time.deltaTime);
    }
}
