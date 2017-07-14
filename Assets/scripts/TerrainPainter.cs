using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TerrainPainter : MonoBehaviour {

	public int TextureID = 0;
	private int lastFrameX = -1;
	private int lastFrameZ = -1;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		int x = (int)Math.Floor(transform.position.x / (200.0 / 256));
		int z = (int)Math.Floor(transform.position.z / (200.0 / 256));
		//Debug.Log (x+" "+z);
		if (x < 255 && z < 255 && x >= 0 && z >= 0&& (x!= lastFrameX || z!=lastFrameZ)) {
			float[,,] map = new float[2, 2, 5];
			for (int i = 0; i < 2; ++i) {
				for (int j = 0; j < 2; ++j) {
					map [i, j, TextureID] = 1;
				}
			}
			GameManager.Current.TerrainObject.terrainData.SetAlphamaps (x, z, map);
		}
		lastFrameX = x;
		lastFrameZ = z;
	}
}
