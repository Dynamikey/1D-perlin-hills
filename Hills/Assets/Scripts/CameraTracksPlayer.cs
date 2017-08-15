using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracksPlayer : MonoBehaviour {

	Transform playerTransform;
	float offsetX;
	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
	
		offsetX = transform.position.x - playerTransform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerTransform!= null) {
			Vector3 pos = transform.position;
			pos.x = offsetX + playerTransform.position.x;
			transform.position = pos;
		}

	}
}
