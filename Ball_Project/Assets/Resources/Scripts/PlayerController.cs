using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (!rb)
            Debug.LogError("This object has no rigidbody");
    }

    void FixedUpdate()
    {
        float vertical = InputManager.instance.verticalMovement;
        float horizontal = InputManager.instance.horizontalMovement;

        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
        rb.AddForce(movement * speed);
    }
}
