using UnityEngine;
using System.Collections;

public class AsteroidMovementScript : MonoBehaviour {

    float speed = 0.5f;
    new Rigidbody rigidbody;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Random.onUnitSphere * speed;
    }
	
}
