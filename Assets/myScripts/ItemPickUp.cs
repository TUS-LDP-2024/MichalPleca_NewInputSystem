using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Transform hand;
    public GameObject pickup;
    private bool itemPickedUp = false;
    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Item" && !itemPickedUp)
        {
            pickUpItem();
        }
    }

    private void pickUpItem()
    {
        itemPickedUp = true;
        pickup.transform.position = hand.transform.position;
        pickup.transform.parent = hand.transform;
    }

    private void OnDrop()
    {
        itemPickedUp=false;
        pickup.transform.parent = null;
    }
}
