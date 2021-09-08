using UnityEngine;

public class MiniComet : MonoBehaviour
{
    Rigidbody2D Bady;
    [SerializeField]
    private float Speed;

    private void Start()
    {
        Bady = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Bady.AddForce(transform.up * Speed, ForceMode2D.Force);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Rum")
        {
            gameObject.SetActive(false);
        }
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            GameManager.GetSharedScore.score++;
            gameObject.SetActive(false);
        }
        if (other.tag == "Laser")
        {
            GameManager.GetSharedScore.score++;
            gameObject.SetActive(false);
        }
        if (other.tag == "Player")
        {
            other.gameObject.SetActive(false);
        }
    }
}
