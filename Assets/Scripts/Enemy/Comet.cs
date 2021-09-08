using UnityEngine;


public class Comet : MonoBehaviour
{
    [SerializeField]
    private float SpeedRotationComet;
    private int direction;
    [SerializeField]
    private GameObject[] Comets;

    int Index;
    void OnEnable()
    {
        int value = Random.Range(0, 2);
        switch (value)
        {
            case 0:
                direction = +1;
                break;
            case 1:
                direction = -1;
                break;
        }
    }
    void Update()
    {
        Move.Rotati(gameObject, direction,SpeedRotationComet);
        Destruction.PermissionNotActive(Comets, gameObject, Index);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Rum" && Comets[3].activeSelf == true)
        {
            Destroy(gameObject);
        }
        if (other.tag == "Bullet" )
        {
            Destroy(other.gameObject);
            GameManager.GetSharedScore.score++;
            for (int i = 0; i < 3; i++)
            {
                Comets[i].SetActive(true);
            }
            Comets[3].SetActive(false);
        }
        if (other.tag == "Laser")
        {
            GameManager.GetSharedScore.score++;
            Destroy(gameObject);
        }
        if (other.tag == "Player")
        {
            other.gameObject.SetActive(false);
        }
    }
}
