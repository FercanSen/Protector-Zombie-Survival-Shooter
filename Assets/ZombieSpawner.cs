using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ZombieSpawner : MonoBehaviour
{

	public GameObject zombiePrefab;

	private float m_SpawnDelay= 2;
	private float m_NextSpawnTime;
	public GameObject myObject;
	public GameObject myObject1;
	public Vector3 center;
	public Vector3 size;
	
	
	// Use this for initialization
	void Start ()
	{
		Instantiate(zombiePrefab);
	}
	
	// Update is called once per frame
	void Update () {
		if (ShouldSpawn())
		{
			Spawn();
		}
		if (Score.score>100)
		{
			myObject.SetActive(true);
		}
		if (Score.score>200)
		{
			myObject1.SetActive(true);
		}
	}

	private void Spawn()
	{
		m_NextSpawnTime = Time.time + m_SpawnDelay;
		
		Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x/2),Random.Range(-size.y/2, size.y/2),Random.Range(-size.z/2, size.z/2));
		
		Instantiate(zombiePrefab, transform.position + pos, Quaternion.identity);
	}

	private bool ShouldSpawn()
	{
		return Time.time >= m_NextSpawnTime;
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = new Color(1,0,0,0.5f);
		Gizmos.DrawCube(transform.localPosition + center,size);
	}
	
	
}
