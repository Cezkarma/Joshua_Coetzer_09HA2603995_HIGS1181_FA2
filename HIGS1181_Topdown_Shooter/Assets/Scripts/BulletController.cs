using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Environment")
        {
            BulletDesctruction();
        }
    }

    private void BulletDesctruction()
    {
        Destroy(gameObject);
    }
}
