using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 temp = this.transform.position;
            temp.z += speed;
            this.transform.position = temp;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 temp = this.transform.position;
            temp.z -= speed;
            this.transform.position = temp;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 temp = this.transform.position;
            temp.x -= speed;
            this.transform.position = temp;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 temp = this.transform.position;
            temp.x += speed;
            this.transform.position = temp;
        }
    }
}
