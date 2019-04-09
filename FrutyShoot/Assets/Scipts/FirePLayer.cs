using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePLay : MonoBehaviour
{
    public GameObject bullet;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space)){
        	GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
        	Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(), transform.parent.GetComponent<Collider2D> ());
        }
    }
}
