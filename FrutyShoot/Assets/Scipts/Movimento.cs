using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    float MaxSpeed = 4f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 x = transform.position;
        x.x += Input.GetAxis("Horizontal") * MaxSpeed * Time.deltaTime;
        transform.position = x;

        Vector3 pos = transform.position;
        pos.y += Input.GetAxis("Vertical") * MaxSpeed * Time.deltaTime;
        transform.position = pos;
    }
}
