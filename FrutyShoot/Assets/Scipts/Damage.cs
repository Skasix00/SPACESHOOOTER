using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
 void OnCollisionEnter2D(Collision2D col) {

 	Destroy (col.gameObject);
 	Destroy (gameObject);
 }
}
