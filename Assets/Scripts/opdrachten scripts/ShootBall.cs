using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 Direction = new Vector2(0f, 0f);
    public Vector2 Direction2 = new Vector2(0f, 0f);
    public float ShootForce = 500f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Direction * ShootForce);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Direction2 * ShootForce);
        }
    }
}
