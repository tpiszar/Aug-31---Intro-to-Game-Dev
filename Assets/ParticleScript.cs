using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject collisionParticle;
    public GameObject triggerParticle;
    public float xRotate = 0;
    public float yRotate = 0;
    public float zRotate = 0;

    //Gets executed when something enters this trigger, or when this object enters a trigger
    private void OnTriggerEnter(Collider other)
    {
        if (triggerParticle != null)
        {
            //The particle will be spawned at the location of this object
            //with the same rotation as this object
            Instantiate(triggerParticle, this.transform.position, this.transform.rotation);
        }
    }

    //Gets executed when something collides whith this object
    private void OnCollisionEnter(Collision collision)
    {
        if (collisionParticle != null)
        {
            Instantiate(collisionParticle, collision.contacts[0].point, Quaternion.Euler(xRotate ,yRotate, zRotate));
        }
    }
}
