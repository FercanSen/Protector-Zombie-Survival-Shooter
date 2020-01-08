using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
	public Image healthBar;
	public float pushPower = 2.0F;

	public float max_health = 100f;
	public float cur_health = 0f;
	public bool alive = true;

	public void setHealthBar()
	{
		float my_health = cur_health / max_health;
		healthBar.transform.localScale=new  Vector3(Mathf.Clamp(my_health,0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
	
	// Use this for initialization
	void Start()
	{
		alive = true;
		cur_health = max_health;
		setHealthBar();
	}

	public void TakeDamage(float amount)
	{
		if (!alive)
		{
			SceneManager.LoadScene("Death");
		}

		if (cur_health<=0)
		{
			cur_health = 0;
			alive = false;
			//SceneManager.LoadScene("Death");
			//gameObject.SetActive(false);
		}
		cur_health -= amount;
		setHealthBar();
	}
	
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		Rigidbody body = hit.collider.attachedRigidbody;

		// no rigidbody
		if (body == null || body.isKinematic)
			return;

		// We dont want to push objects below us
		if (hit.moveDirection.y < -0.3f)
			return;

		// Calculate push direction from move direction,
		// we only push objects to the sides never up and down
		Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

		// If you know how fast your character is trying to move,
		// then you can also multiply the push velocity by that.

		// Apply the push
		body.velocity = pushDir * pushPower;
	}
}

	
