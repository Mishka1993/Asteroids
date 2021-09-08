using System.Collections;
using UnityEngine;

public class ManagerEnemies : MonoBehaviour
{
    [SerializeField]
    private GameObject Comet;
    [SerializeField]
    private GameObject UFO;
    [SerializeField]
    private GameObject m_Parent;
    [SerializeField]
    private float SpeedBullet = 20f;

    int m_Random;

    void Start()
    {
        StartCoroutine(CreatyComet());
        StartCoroutine(CreatyUFO());
    }
    IEnumerator CreatyComet()
    {
        m_Random = Random.Range(0,2);
        float m_Y;
        if (m_Random == 0)
        {
            m_Y = 619f;
            float m_Garvity = 0.2f;
            Creaty.CreatyComet(Comet, m_Parent, gameObject, SpeedBullet, m_Y, m_Garvity);
        }
        else 
        {
            m_Y = -619f;
            float m_Garvity = -0.2f;
            Creaty.CreatyComet(Comet, m_Parent, gameObject, SpeedBullet, m_Y, m_Garvity);
        }
        yield return new WaitForSeconds(5f);
        StartCoroutine(CreatyComet());
    }
    IEnumerator CreatyUFO()
    {
        m_Random = Random.Range(0, 2);
        float m_X;
        if (m_Random == 0)
        {
            m_X = 619f;
            Creaty.CreatyUFO(UFO,m_Parent,gameObject,m_X);      
        }
        else
        {
            m_X = -619f;
            Creaty.CreatyUFO(UFO, m_Parent, gameObject, m_X);
        }
        yield return new WaitForSeconds(10f);
        StartCoroutine(CreatyUFO());
    }
}
