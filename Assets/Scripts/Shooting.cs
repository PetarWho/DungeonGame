using PlayerProps;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    
    float waitTime = 100 / Player.AttackSpeed / 100;
    private float timeStamp = Mathf.Infinity;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            timeStamp = Time.time + waitTime;
        }

        if (Input.GetMouseButtonUp(0))
        {
            timeStamp = Mathf.Infinity;
        }

        if (Time.time >= timeStamp)
        {
            Shoot();
            timeStamp = Time.time + waitTime;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * Player.BulletForce, ForceMode2D.Impulse);
    }
}