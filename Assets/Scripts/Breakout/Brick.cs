using UnityEngine;

public class Brick : MonoBehaviour, IRestart
{
    public void Restart() {
        gameObject.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        gameObject.SetActive(false);
    }
}
