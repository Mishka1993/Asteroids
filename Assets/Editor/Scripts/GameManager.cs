using System.Collections;
using System.Collections.Generic;

public class GameManager
{
   
    private static GameManager m_score = null;
    public static GameManager GetSharedScore
    {
        get {
                if (m_score == null) {
                m_score = new GameManager();
                }
                return m_score;
            }
    }
    public float score;
}