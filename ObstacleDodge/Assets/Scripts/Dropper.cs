using System;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropDelay = 3f;

    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    private void Update()
    {
        if (Time.time > dropDelay)
        {
            Debug.Log("Dropper activated, enabling gravity.");
            rigidBody.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}
