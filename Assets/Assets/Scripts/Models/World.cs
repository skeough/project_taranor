using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World {

	Floor[,,] floor;
	int width;
	int height;
	int length;

	public int Width {get {return width;} }
	public int Height {get {return height;} }
	public int Length {get {return length;} }

	public World(int width = 50, int length = 50, int height = 1) {
		this.width = width;
		this.height = height;
		this.length = length;

		floor = new Floor[width,height,length];
		for (int y = 0; y < height; y++) {
			for (int z = 0; z < length; z++) {
				for (int x = 0; x < width; x++) {
					floor[x,y,z] = new Floor(this,x,y,z);
				}
			}	
		}

		Debug.Log("World created with " + (width*length*height) +" Floors!");
	}

	public Floor GetFloorAt(int x, int y, int z) {
		if(floor[x,y,z] == null) {
			Debug.LogWarning("Floor ("+x+","+y+","+z+") is out of range.");
			return null;
		}

		return floor[x,y,z];
	}
}
