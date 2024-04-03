using UnityEngine;


public class move : MonoBehaviour
{

    [SerializeField] private float speedPlayer;
    [SerializeField] private float jumpPlayer;

    private Rigidbody2D rb;
    private SpriteRenderer sp;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speedPlayer, 0);
            sp.flipX = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speedPlayer, 0);
            sp.flipX = false;
        }
    }
}