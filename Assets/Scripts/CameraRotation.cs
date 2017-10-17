using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	// Attached with the player
	void Start () {
		//Player property
		print (transform);
		Camera camera = GetComponentInChildren<Camera> ();
		//Camera Property
		print (camera.transform);
	}
	
	// Update is called once per frame
	void Update () {
		//If X-Axis, move the whole body.
		//If Y-Aixs, move only the head (aka. Camera)
		float mouseX = Input.GetAxis ("Mouse X");
		transform.localRotation = Quaternion.Euler (0, mouseX * 10.0f, 0) * transform.localRotation;

		float mouseY = Input.GetAxis ("Mouse Y");
		Camera camera = GetComponentInChildren<Camera> ();
		camera.transform.localRotation = Quaternion.Euler (mouseY * 10.0f, 0, 0) * camera.transform.localRotation;
	}
}
