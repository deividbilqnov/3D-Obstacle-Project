using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    
    void Start()
    {
        
    }


    void Update()
    {
        EnemyMove();
    }


    void EnemyMove()
    {
        transform.position = transform.position + new Vector3(-moveSpeed, 0f,0f);
    }
    void OnCollisionEnter(Collision other) 
    {
        transform.position = transform.position + new Vector3(moveSpeed, 0f,0f);
        Debug.Log("Obstacle hit the wall");
    }
}
