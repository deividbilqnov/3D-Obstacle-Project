using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    
    void Start()
    {
        InstructionsInConsole();
    }

    void Update()
    {
        MovePlayer();
    }

    void InstructionsInConsole()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move with WASD or arrow keys");
        Debug.Log("Dont hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(-xValue, 0f, -zValue);
    }

}
