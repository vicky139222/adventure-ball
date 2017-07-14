using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionListenner : MonoBehaviour {
	// Use this for initialization
	private TerrainPainter myPainter;
	void Start () {
		myPainter = GetComponent<TerrainPainter> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision){
		TerrainPainter painter = collision.gameObject.GetComponent<TerrainPainter> ();
		if (painter != null) {
			painter.TextureID = myPainter.TextureID;
			MeshRenderer renderer = collision.gameObject.GetComponent<MeshRenderer> ();
			if (renderer != null) {
				renderer.material.color = Color.green;
			}
		}

	}
}
