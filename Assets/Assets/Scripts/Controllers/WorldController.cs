using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {

	World world;

	// Use this for initialization
	void Start () {
		world = new World();

		Material Air = Resources.Load("Graphics/Blocks/Air", typeof(Material)) as Material;

		for (int y = 0; y < world.Height; y++) {
			for (int z = 0; z < world.Length; z++) {
				for (int x = 0; x < world.Width; x++) {
					GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
					floor.name = "Floor_"+x+"_"+y+"_"+z;
					floor.transform.localScale = new Vector3 (1,.1f,1);
					floor.GetComponent<Renderer>().material = Air;
					floor.transform.position = new Vector3 (x ,y, z);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
