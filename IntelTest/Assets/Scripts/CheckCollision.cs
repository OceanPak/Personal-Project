using UnityEngine;
using System.Collections;

public class CheckCollision : MonoBehaviour {

    public float radius = 0f;
    public Collider[] colliders;

	// Use this for initialization
	public void Collision () {
        colliders = Physics.OverlapSphere(transform.position, radius);
	}
	
}
