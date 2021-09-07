using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEnemies : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    [SerializeField]
    private GameObject m_Parent;
    [SerializeField]
    private float SpeedBullet = 20f;
    private GameObject prefab;

    int m_Random;

    void Start()
    {
        StartCoroutine(CreatyCamet());
    }
    IEnumerator CreatyCamet()
    {
        m_Random = Random.Range(0,2);
        float m_Y;
        if (m_Random == 0)
        {
            m_Y = 619f;
            prefab = Instantiate(obj, new Vector3(100, 100, transform.localPosition.z), Quaternion.identity, m_Parent.transform.parent);
            prefab.transform.localPosition = new Vector3(Random.Range(-884f, 884f), m_Y, transform.localPosition.z);
            Rigidbody2D Run = prefab.GetComponent<Rigidbody2D>();
            Run.gravityScale = 0.2f;
            Run.AddForce(-prefab.transform.position * SpeedBullet * Time.deltaTime, ForceMode2D.Impulse);
        }
        else 
        {
            m_Y = -619f;
            prefab = Instantiate(obj, new Vector3(100, 100, transform.localPosition.z), Quaternion.identity, m_Parent.transform.parent);
            prefab.transform.localPosition = new Vector3(Random.Range(-884f, 884f), m_Y, transform.localPosition.z);
            Rigidbody2D Run = prefab.GetComponent<Rigidbody2D>();
            Run.gravityScale = -0.2f;
            Run.AddForce(-prefab.transform.position * SpeedBullet * Time.deltaTime, ForceMode2D.Impulse);
        }
        yield return new WaitForSeconds(4f);
        StartCoroutine(CreatyCamet());
    }
}

