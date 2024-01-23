using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCollisionHandler : MonoBehaviour
{
    public int damageAmount = 100;
    public int pointsToAdd = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damageAmount);
            }

            PlayerData.Instance.AddPoints(pointsToAdd);

            Destroy(gameObject);
        }
    }
}
