using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GameObject ball = Instantiate (ballPrefab);
			Rigidbody rb = ball.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.left * 10.0f;

		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GameObject ball = Instantiate (ballPrefab);
			Rigidbody rb = ball.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.right * 10.0f;
		
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GameObject ball = Instantiate (ballPrefab);
			Rigidbody rb = ball.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.forward * 10.0f;
		
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GameObject ball = Instantiate (ballPrefab);
			Rigidbody rb = ball.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.back * 10.0f;
		} 
	}
}
