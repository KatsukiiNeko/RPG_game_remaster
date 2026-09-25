using UnityEngine;

public class Playercolision : MonoBehaviour
{
    private GameManager GameManager;
    private void Awake()
    {
        GameManager = FindAnyObjectByType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            GameManager.AddScore(1);
        }
        else if (collision.CompareTag("trap"))
        {
            GameManager.GameOver();
        }
        else if (collision.CompareTag("enemy"))
        {
            GameManager.GameOver();
        }
    }
}
