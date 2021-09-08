using UnityEngine;

public class Destruction : Transform
{
   public static void PermissionNotActive(GameObject[] m_ArrowObj, GameObject ThisObj, int m_Index)
    {
        m_Index = 0;
        foreach (GameObject Obj in m_ArrowObj)
        {
            if (Obj.activeSelf)
            {
                m_Index++;
            }
        }
        if (m_Index == 0)
        {
            Destroy(ThisObj.gameObject);
        }
    }
}
