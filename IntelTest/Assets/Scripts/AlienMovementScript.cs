using UnityEngine;
using System.Collections;

public class AlienMovementScript : MonoBehaviour
{

    float speed = 2f;
    new Rigidbody rigidbody;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Random.onUnitSphere * speed;
    }

}
