using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody myRigidbody;
    [SerializeField] float TimeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;

        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeToWait)
        {
            Debug.Log(" 5 seconds has elapsed");
            meshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
