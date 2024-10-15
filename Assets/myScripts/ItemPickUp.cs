using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Transform hand;
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

    private void pickUpItem(GameObject _pickup)
    {
        _pickup = _thePickedUpItem;
        _itemPickedUp = true;
        _pickup.transform.position = hand.transform.position;
        _pickup.transform.parent = hand.transform;
        _pickup.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnDrop()
    {
        _itemPickedUp = false;
        _thePickedUpItem.transform.parent = null;
        _thePickedUpItem.GetComponent<Rigidbody>().isKinematic = false;
    }
}
