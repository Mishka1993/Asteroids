using UnityEngine;
using UnityEngine.UI;
using System;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject Laser;
    [SerializeField]
    private Text SumTextLaser;
    [SerializeField]
    private Text TextRech;
    private int SumLaser = 3;
    private float timeLeft = 30f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Laser.activeSelf == false)
        {
            Instantiate(bullet, transform.position, transform.rotation, transform.parent);
        }
        if (Input.GetMouseButtonDown(1))
        {
            if(SumLaser != 0 && Laser.activeSelf != true)
            {
                Laser.SetActive(true);
                SumLaser--;
                SumTextLaser.text = SumLaser.ToString();
            }
        }
        if (SumLaser == 0)
        {
            timeLeft -= Time.deltaTime;
            TextRech.text = Math.Round(timeLeft,2).ToString();
            if (timeLeft < 0)
            {
                SumTextLaser.text = "3";
                TextRech.text = "30";
                SumLaser = 3;
            }
        }
    }
}
