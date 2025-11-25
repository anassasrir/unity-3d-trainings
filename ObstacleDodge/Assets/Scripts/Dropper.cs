using System;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropDelay = 3f;

    void Update()
    {
        if(Time.time > dropDelay)
        {
            Debug.Log("Dropper activated, enabling gravity.");
            GetComponent<Rigidbody>().useGravity = true;

        }
    }
}
