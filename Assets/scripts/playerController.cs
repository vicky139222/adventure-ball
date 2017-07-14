using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	public Text countText;
	public Text winText;
	private int count;
	void Start(){
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";

		MeshRenderer renderer = GetComponent<MeshRenderer> ();
		renderer.material.color = Color.green;
	}
	void FixedUpdate(){
		float moveSideway = Input.GetAxis ("Horizontal");
		float moveFront = Input.GetAxis ("Vertical");
		Vector3 sideway = Vector3.Normalize(Camera.main.transform.right) * speed * moveSideway;
		Vector3 front   = Vector3.Normalize(Camera.main.transform.forward) * speed * moveFront;
		rb.AddForce(sideway + front);
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}
	void SetCountText(){
		countText.text = "Count: " + count + "/32";
		if (count >= 32)
		{
			winText.text = "You Win!";
		}
	}
}
