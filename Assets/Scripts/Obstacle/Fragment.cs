using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment : MonoBehaviour
{
    private Collider _childCollider;
    private Rigidbody _childRigidbody;

    private void Start()
    {
        _childCollider = GetComponent<Collider>();
        _childRigidbody = GetComponent<Rigidbody>();
    }

    public void Init()
    {
        transform.parent = GameController.Controller.PatentFragment;
        _childCollider.enabled = true;
        _childRigidbody.useGravity = true;
        _childRigidbody.isKinematic = false;

        Invoke("DestroyFragment", 1f);
    }

    public void DestroyFragment()
    {
        Destroy(gameObject);
    }
}