using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerData", menuName = "PlayerData" )]
public class PlayerData : ScriptableObject
{
    public static PlayerData Instance;

    public int Points;
    public float HP;

    private void OnEnable()
    {
        Instance = this;
    }

    public void AddPoints(int pointsToAdd)
    {
        Points += pointsToAdd;
    }
}