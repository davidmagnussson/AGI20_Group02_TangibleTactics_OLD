using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class monsterMovement : MonoBehaviour
{


    public float speed = 2f;
    // Update is called once per frame

    public Vector3 target;
    void FixedUpdate()
    {
        target = new Vector3(0, -1, 0);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Player")
        {
            FindObjectOfType<monsterSpawner>().DestroyMonster(gameObject);
        }


    }
}
