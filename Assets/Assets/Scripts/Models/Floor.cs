using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor {

	private enum Type {Empty, Solid, Liquid}

	Floor.Type type = Type.Empty;

	InstalledObjects installedObjects;
	LooseObject looseObject;

	World world;
	int x;
	int y;
	int z;

	public Floor( World world, int x, int y, int z) {
		this.world = world;
		this.x = x;
		this.y = y;
		this.z = z;
	}

	public Floor createFloor() {
		
		return null;
	}
}
