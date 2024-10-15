using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Transform hand;
    public GameObject pickup;
    private GameObject _thePickedUpItem;
    private bool _itemPickedUp = false;
    void Start()
    {
    }

    void Update()
    {

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Item" && !_itemPickedUp)
        {
            _thePickedUpItem = hit.gameObject;
            pickUpItem(hit.gameObject);
        }
    }

    private void pickUpItem(GameObject pickup)
    {
        _thePickedUpItem = pickup;
        _itemPickedUp = true;
        pickup.transform.position = hand.transform.position;
        pickup.transform.parent = hand.transform;
        pickup.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnDrop()
    {
        pickup.GetComponent<Rigidbody>().isKinematic = false;
        _itemPickedUp = false;
        pickup.transform.parent = null;
    }
}
