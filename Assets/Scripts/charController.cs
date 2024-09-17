using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class charController : MonoBehaviour
{
    public GameInputController playerGameInputController;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (playerGameInputController.isFiring) {
            Debug.Log("isfiring");
        }

 
    }
}
