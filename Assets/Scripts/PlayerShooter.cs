using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject shotPrefab;
    public float shotSpeed = 10f;
    public int damageAmount = 100;
    public int pointsToAdd = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject shot = Instantiate(shotPrefab, transform.position, Quaternion.identity);

        Rigidbody2D rb = shot.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * shotSpeed;

        BoxCollider2D collider = shot.GetComponent<BoxCollider2D>();
        collider.isTrigger = true;

        ShotCollisionHandler collisionHandler = shot.GetComponent<ShotCollisionHandler>();
        collisionHandler.damageAmount = damageAmount;
        collisionHandler.pointsToAdd = pointsToAdd;
    }
}
