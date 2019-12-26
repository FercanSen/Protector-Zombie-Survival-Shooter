using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
	public Image healthBar;

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
	
	
}

	
