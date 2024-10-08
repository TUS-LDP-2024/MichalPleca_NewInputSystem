using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouchController : MonoBehaviour
{
    private bool allowStand;
    void Start()
    {
        
    }

    void Update()
    {
        crouch_();
        stand_();
    }

    void stand_()
    {
        if (Physics.Raycast(transform.position, Vector3.up, 5f, 6))
        {
            allowStand = false;
            Debug.Log("Cannot stand, object in the way");
        }
        else
        {
            Debug.Log("Can stand");
            allowStand = true;
        }
    }

    void crouch_()
    {
        if (allowStand && StarterAssetsInputs.crouch)
        {
            Debug.Log("crouching");
        }
    }
}
