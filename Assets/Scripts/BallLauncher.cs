using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	public float ballVelocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject ball = Instantiate (ballPrefab);
			ball.transform.position = transform.position;
			Rigidbody rb = ball.GetComponent<Rigidbody> ();
			Camera camera = GetComponentInChildren<Camera> ();
			rb.velocity = camera.transform.rotation * Vector3.forward * ballVelocity;
		}
	}
}
