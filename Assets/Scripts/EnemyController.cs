using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float MoveSpeed;
    public int DamageAmount = 10;

    void Update()
    {
        Vector3 enemyPos = transform.position;

        enemyPos.x -= MoveSpeed * Time.deltaTime;

        transform.position = enemyPos;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DealDamageToPlayer();
        }
    }

    void DealDamageToPlayer()
    {
        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();

        if (playerHealth != null) 
        {
            playerHealth.TakeDamage(DamageAmount);
        }
    }
}
