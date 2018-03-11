using UnityEngine;
using System.Collections;

public class MovingForward : MonoBehaviour {

    Rigidbody rigidbody;
    TrackingAction tracking;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        tracking = GetComponent<TrackingAction>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //rigidbody.AddForce(Vector3.forward * Time.deltaTime*50);
        //float currentX = tracking.VirtualWorldBoxCenter.x;
        //float currentY = tracking.VirtualWorldBoxCenter.y;
        float currentZ = tracking.VirtualWorldBoxCenter.z;

        //currentX += 0.05f;
        //currentY += 0.05f;
        currentZ += 0.1f;

        //tracking.VirtualWorldBoxCenter.x = currentX;
        //tracking.VirtualWorldBoxCenter.x = currentX;
        tracking.VirtualWorldBoxCenter.z = currentZ;
        //transform.position += Vector3.forward * Time.deltaTime;
    }
}
