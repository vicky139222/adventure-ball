using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRun : MonoBehaviour {
	public float velocity = 1.0f;
	private Rigidbody rb;
	private double time = 1000;
	// Use this for initialization
	private Vector3 randomForce;
	void Start () {
		rb = GetComponent<Rigidbody>();
		MeshRenderer renderer = GetComponent<MeshRenderer> ();
		renderer.material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		time = Time.deltaTime + time;
		if (time > 3) {
			randomForce = new Vector3 (Random.Range (-10.0f, 10.0f) * velocity, 0, Random.Range (-10.0f, 10.0f) * velocity);

			time = 0;
		}
		rb.AddForce (randomForce);
	}
}
