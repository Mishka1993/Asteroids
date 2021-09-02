using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoard : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private Text[] ArrowInfo;

    private void Update()
    {
        ArrowInfo[0].text = "X(" + Math.Round(Player.transform.localPosition.x, 0) + ")";
        ArrowInfo[1].text = "Y(" + Math.Round(Player.transform.localPosition.y, 0) + ")";
        ArrowInfo[2].text = "(" + Math.Round(Player.GetComponent<RectTransform>().transform.rotation.eulerAngles.z, 0) + ")";
        ArrowInfo[3].text = "(" + Math.Round(Player.GetComponent<Rigidbody2D>().velocity.magnitude, 0) + ")";
    }
}
