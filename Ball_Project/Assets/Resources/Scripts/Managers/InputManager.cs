using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : GenericSingleton<InputManager>
{
    public float verticalMovement;
    public float horizontalMovement;

    public override void Awake()
    {
        base.Awake();
    }

    private void Update()
    {
        verticalMovement = Input.GetAxis("Vertical");
        horizontalMovement = Input.GetAxis("Horizontal");
    }
}
