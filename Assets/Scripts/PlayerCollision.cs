using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Monster" && col.otherCollider.tag == "Player")
        {
            PlayerHealth.TakeDamage(10);
        }
    }

    private float secondsCollided = 0f;
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.collider.tag == "Monster" && col.otherCollider.tag == "Player")
        {
            secondsCollided += Time.deltaTime;
            if (secondsCollided >= 1)
            {
                PlayerHealth.TakeDamage(10);
                secondsCollided = 0f;
            }
        }
    }
}
