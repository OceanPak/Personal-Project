using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    Transform player;
    float offSetZ;

	// Use this for initialization
	void Start () {
        GameObject player_game_object = GameObject.FindGameObjectWithTag("Player");
        player = player_game_object.transform;
        offSetZ = transform.position.z - player.position.z;
	}
	
	// Update is called once per frame
	void Update () {
	    if (player!= null)
        {
            Vector3 pos = transform.position;
            pos.z = player.position.z + offSetZ;
            transform.position = pos;
        }
	}
}
