using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class charController : MonoBehaviour
{
    public GameInputController playerGameInputController;
    void Start()
    {
        
    }

    void Update()
    {
        if (playerGameInputController.isFiring) {
            Debug.Log("isfiring");
        }
    }
}
