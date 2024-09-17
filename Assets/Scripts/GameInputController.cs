using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInputController : MonoBehaviour
{
    public bool isFiring = false;
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
}
