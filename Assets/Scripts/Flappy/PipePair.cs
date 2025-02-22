using UnityEngine;

public class PipePair : MonoBehaviour, IRestart, IStop
{
    private Rigidbody2D rb;

    [SerializeField] private float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.left * speed;
    }
    public void Restart() {
        Destroy(gameObject);
    }

    public void Stop() {
        rb.simulated = false;
    }
}
