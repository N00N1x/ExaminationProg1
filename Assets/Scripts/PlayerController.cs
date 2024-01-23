using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public PlayerData CurrentPlayerData = null;

    public TextMeshProUGUI HPText = null;
    public TextMeshProUGUI PointText = null;

    public float movespeed;

    public float minY = -5.5f;
    public float maxY = 5.5f;

    void Update()
    {
        Vector3 playerPos = transform.position;

        if (Input.GetKey(KeyCode.W)) 
        {
            playerPos.y += movespeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) 
        {
            playerPos.y -= movespeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            playerPos.x += movespeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A)) 
        {
            playerPos.x -= movespeed * Time.deltaTime;
        }


        transform.position = playerPos;

        HPText.text = playerHealth.currentHealth + " HP";
        PointText.text = CurrentPlayerData.Points + " Points";
    }
}