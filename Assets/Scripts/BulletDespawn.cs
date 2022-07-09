using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : MonoBehaviour
{
    public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player" && col.otherCollider.tag == "Bullet")
        {
            return;
        }

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(col.otherCollider.gameObject);
    }
}