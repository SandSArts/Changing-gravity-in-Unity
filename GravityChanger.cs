// Programmed by Shashank.S - creator of SandS Arts , Mail me at sandsarts.developer@gmail.com
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour {
public float x;
public float y;
public float z;
public bool ThreeD;
public bool TwoD;

	void Update () {
		if(ThreeD)                              //if you are using this script in your 3D games
		Physics.gravity = new Vector3(x, y, z); //changing gravity experienced by this object
		if(TwoD)                                //if you are using this script in your 2D games
		Physics2D.gravity = new Vector2(x, y);  //changing gravity experienced by this object
	}
}
