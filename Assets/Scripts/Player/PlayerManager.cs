using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D Spaceship;
    [SerializeField]
    private float Speed = 20f;
    [SerializeField]
    private float SpeedRotation = 10f;
    

    void Start()
    {
        Spaceship = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move.MovePlayer(Spaceship, gameObject, Speed, SpeedRotation);
    }

}