using System.Collections;
using UnityEngine;

public class LaserManager : MonoBehaviour
{
    void OnEnable()
    {
        StartCoroutine(LifeLaser());
    }
    IEnumerator LifeLaser()
    {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }
}
