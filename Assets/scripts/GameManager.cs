using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Current;

	public Terrain TerrainObject;
	float[,,] map = new float[256, 256, 5];

	void Awake() {
		Current = this;

	}

	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < 256; ++i) {
			for (int j = 0; j < 256; ++j) {
				map [i, j, 2] = 1;
			}
		}

		TerrainObject.terrainData.SetAlphamaps(0, 0, map);
		//Debug.Log (TerrainObject.terrainData.size);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
