using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillAmmo : MonoBehaviour
{
	public static float ammoBullets= 0;
	public static float refillAmount = 60;

	GunScript bulletsIHave;
	
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name == "Cube")
		{
			//collision.gameObject.GetComponent<GunScript>().bulletsIHave+= 50;
			//bulletsIHave = collision.gameObject.GetComponent<GunScript>();
			//ammoBullets += bulletsIHave.refillAmount;
			
			Destroy(collision.gameObject);
		}
		
        Debug.Log("Ammo box touched");
	}
}
