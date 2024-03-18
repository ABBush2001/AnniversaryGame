using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbcdeMovement : MonoBehaviour
{
    public Rigidbody2D theRB; //rigidbody on the object
    public float moveSpeed = 2f; //how fast we going

    private void Start()
    {
        
    }

    //physics calculation should always be done in fixed update
    private void FixedUpdate()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, 0);
    }
}
