using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	void OnTriggerEnter (Collider collider1)
    {
        Destroy(collider1);
    }
}
