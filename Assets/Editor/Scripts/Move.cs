using UnityEngine;

public class Move : Transform
{
    public static void MovePlayer(Rigidbody2D m_Obj, GameObject ThisObj, float m_SMove, float m_SRotation)
    {
        float VerticalActive = Input.GetAxis("Vertical");
        if (VerticalActive > 0.1)
        {
            m_Obj.AddForce(ThisObj.transform.up * m_SMove);
        }

        float HorizontalActive = Input.GetAxis("Horizontal");
        ThisObj.transform.Rotate(0f, 0f, HorizontalActive * m_SRotation * Time.deltaTime);


        if (ThisObj.transform.localPosition.y > 623.5f)
        {
            ThisObj.transform.localPosition = new Vector3(-ThisObj.transform.localPosition.x, -623.5f, 0f);
        }
        else if (ThisObj.transform.localPosition.y < -623.5f)
        {
            ThisObj.transform.localPosition = new Vector3(-ThisObj.transform.localPosition.x, 623.5f, 0f);
        }

        if (ThisObj.transform.localPosition.x > 1054f)
        {
            ThisObj.transform.localPosition = new Vector3(-1054f, -ThisObj.transform.localPosition.y, 0f);
        }
        else if (ThisObj.transform.localPosition.x < -1054f)
        {
            ThisObj.transform.localPosition = new Vector3(1054f, -ThisObj.transform.localPosition.y, 0f);
        }
    }
    public static void Chase(GameObject m_target, GameObject ThisObj, Rigidbody2D m_Rb, float m_Speed)
    {
        var dir = (m_target.transform.position - ThisObj.transform.position).normalized;
        m_Rb.velocity = dir * m_Speed;
    }
    public static void Rotati(GameObject ThisObj, int m_Z,float m_Speed)
    {
        ThisObj.transform.Rotate(0, 0, m_Z * m_Speed * Time.deltaTime);
        
    }
}
