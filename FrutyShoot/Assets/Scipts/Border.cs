﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
	void onCollisionEnter2D(Collision2D col){
if(col.gameObject.name != "PlayerShip"){
	Destroy(col.gameObject);
}

	}
}
