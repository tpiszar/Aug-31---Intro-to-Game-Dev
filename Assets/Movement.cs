using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;
    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(x, 0, y);
        movement = movement.normalized * speed * Time.deltaTime;

        //Vector3 newPosition = transform.position;
        //newPosition = newPosition + movement;

        //transform.position = newPosition;
        controller.Move(movement);

        //https://docs.unity3d.com/ScriptReference/CharacterController.Move.html
    }
}
