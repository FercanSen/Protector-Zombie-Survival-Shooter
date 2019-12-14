using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

	public GameObject zombiePrefab;

	private float m_SpawnDelay= 10;
	private float m_NextSpawnTime;
	
	
	
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
	}

	private void Spawn()
	{
		m_NextSpawnTime = Time.time + m_SpawnDelay;
		Instantiate(zombiePrefab, transform.position, transform.rotation);
	}

	private bool ShouldSpawn()
	{
		return Time.time >= m_NextSpawnTime;
	}
}
