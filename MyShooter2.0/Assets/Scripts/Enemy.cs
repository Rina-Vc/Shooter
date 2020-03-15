using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject hero;
    public GameObject opponent;
    public Rigidbody2D opponent_rb;
    public float opponent_speed = 20f;
    public float opponent_distance = 20f;
    public Transform waypointA, waypointB;
    public Vector3 direction;
    public Transform opponent_pos;
    private Vector3 player;

    void Start()
    {
        opponent = GameObject.FindWithTag("Opponent");
        hero = GameObject.FindWithTag("Player");
        opponent_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");

        opponent = GameObject.FindWithTag("Opponent");
        hero = GameObject.FindWithTag("Player");

        if (opponent.transform.position.x + 20 <= hero.transform.position.x - 20)
        {
            player = opponent.transform.position;
            player.x = transform.position.x;
            transform.position = Vector3.MoveTowards(transform.position, player, opponent_speed * Time.deltaTime);
        }

        else if (opponent.transform.position.x - 20 >= hero.transform.position.x + 20)
        {
            player = opponent.transform.position;
            player.x = transform.position.x;
            transform.position = Vector3.MoveTowards(transform.position, player, opponent_speed * Time.deltaTime);
        }
    }
}



