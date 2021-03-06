﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnInterval = 1f;
    public GameObject[] enemy;
    public Transform[] SpawnPos;

    GameObject Player;

    float SpawnTime;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        SpawnTime = SpawnInterval;
    }

    void Update()
    {
        if (Player != null)
        {
            transform.position = Player.transform.position;
        }

        if (SpawnTime <= 0)
        {
            Instantiate(enemy[Random.Range(0, enemy.Length)], SpawnPos[Random.Range(0, SpawnPos.Length)].position, Quaternion.identity);
            SpawnTime = SpawnInterval;
        }

        else
        {
            SpawnTime -= Time.deltaTime;
        }
    }
}
