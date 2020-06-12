﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player1");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
