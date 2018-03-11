using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour {

    float speed = 10f;
    
    void Update ()
    {
        transform.RotateAround(transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
