using System.Collections.Generic;
using UnityEngine;

public class HealthAnimate : MonoBehaviour {

	private Rigidbody rb;
	private Vector3 _begPos;
	private float size;
	private bool gitbig;

	private float scaleSpeed = 0.03f;


	// Use this for initialization
	void Start () {
		_begPos = transform.position; 
		size = 1.0f;
		gitbig = true;
	}

	// Update is called once per frame
	void FixedUpdate () {
		transform.position = _begPos + new Vector3 (0.0f, Mathf.Sin (Time.time) * 0.2f, 0.0f);
		transform.Rotate (0.0f, 2.0f, 0.0f);
		float baser = (Mathf.Sin (Time.time * 2) * 0.2f) + 1.0f;
		transform.localScale = new Vector3 (baser, baser, baser);
	}
}
