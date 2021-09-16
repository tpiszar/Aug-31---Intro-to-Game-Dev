using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject clouds;
    public bool next = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = this.transform.position;
        temp.x += speed * Time.deltaTime;
        this.transform.position = temp;

        if (temp.x >= 0 && !next)
        {
            Instantiate(clouds, new Vector3(-97, 17.9f, 40f), Quaternion.identity);
            next = true;
        }
        if (temp.x >= 101)
        {
            Destroy(clouds);
        }
    }
}
