using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameInputController : MonoBehaviour
{
    public bool isFiring = false;
    public float speed = 2;
    public Vector2 leftright;
    public Vector2 forwardbackward;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnFire()
    {
        if (isFiring)
        {
            isFiring = false;
        }
        else if (!isFiring)
        {
            isFiring = true;
        }
    }

    void OnMove()
    {
        
        Debug.Log("onMoveFiring");
    }
}
