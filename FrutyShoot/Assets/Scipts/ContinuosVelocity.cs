using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuosVelocity : MonoBehaviour
{
 	public Vector2 velocity;
 	void start()
 	{
 		GetComponent<Rigidbody2D>().velocity = velocity;

 	}
}
