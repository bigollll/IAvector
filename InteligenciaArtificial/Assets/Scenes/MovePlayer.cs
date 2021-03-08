using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed;

    Rigidbody Rig;

    private void Start()
    {
        Rig = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 Position = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Rig.velocity = Position * speed;

    }
}
