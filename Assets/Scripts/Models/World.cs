using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World {

	Cube[,,] cubes;
	int width;
	int height;
	int length;

	public World(int width = 50, int length = 50, int height = 3) {
		this.width = width;
		this.height = height;
		this.length = length;
	}
}
