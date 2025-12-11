using UnityEngine;

public class Bullet_Fanst : MonoBehaviour
{
    [SerializeField] public float Speed;
    private Transform player;
    private Rigidbody2D rb;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();

        LauncherBulett();

        Destroy(gameObject, 5);
    }

    void Update()
    {
        transform.position += transform.up * Speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player" && collision.tag != "Bullet")
            Destroy(gameObject);
    }

    private void LauncherBulett()
    {
        Vector2 directionToPlayer = (player.position - transform.position).normalized;
        rb.linearVelocity = directionToPlayer * Speed;

    }
}
