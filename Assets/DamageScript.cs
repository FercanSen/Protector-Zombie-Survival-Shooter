using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    float speed=50f;
    float damage=1f;
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
        transform.Rotate(Vector3.up* Time.deltaTime*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
        //other.gameObject.GetComponent<>()
    }
}