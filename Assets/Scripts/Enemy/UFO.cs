using UnityEngine;


public class UFO : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private InfoBoard Board;
    Rigidbody2D rb;
    
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        if(target.activeSelf == true)
        {
            Move.Chase(target, gameObject, rb, speed);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            GameManager.GetSharedScore.score++;
            Destroy(gameObject);
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
