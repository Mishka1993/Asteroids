using UnityEngine;

public class Creaty : Transform
{
    public static void CreatyComet(GameObject m_Prefab, GameObject m_Parent, GameObject ThisObj, float m_Speed, float m_Y, float m_gravity)
    {
        GameObject PrefabComet = Instantiate(m_Prefab, new Vector3(100, 100, ThisObj.transform.localPosition.z), Quaternion.identity, m_Parent.transform.parent);
        PrefabComet.transform.localPosition = new Vector3(Random.Range(-884f, 884f), m_Y, ThisObj.transform.localPosition.z);
        Rigidbody2D Run = PrefabComet.GetComponent<Rigidbody2D>();
        Run.gravityScale = m_gravity;
        Run.AddForce(m_Speed * Time.deltaTime * -PrefabComet.transform.position, ForceMode2D.Impulse);
    }
    public static void CreatyUFO(GameObject m_Prefab, GameObject m_Parent, GameObject ThisObj, float m_X)
    {
        GameObject PrefabUFO = Instantiate(m_Prefab, new Vector3(100, 100, ThisObj.transform.localPosition.z), Quaternion.identity, m_Parent.transform.parent);
        PrefabUFO.transform.localPosition = new Vector3(Random.Range(-884f, 884f), m_X, ThisObj.transform.localPosition.z);
    }
}
