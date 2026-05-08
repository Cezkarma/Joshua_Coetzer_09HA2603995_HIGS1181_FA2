using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            EnemyDestruction();
        }
    }

    private void EnemyDestruction()
    {
        GameManager.Instance.EnemyKilled();
        Destroy(gameObject);
    }
}
