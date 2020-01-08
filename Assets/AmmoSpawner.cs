using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AmmoSpawner : MonoBehaviour
{

    public GameObject ammoBox;

    private float m_SpawnDelay= 20;
    private float m_NextSpawnTime;

    public Vector3 center;
    public Vector3 size;
	
	
    // Use this for initialization
    void Start ()
    {
        
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
		
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x/2),Random.Range(-size.y/2, size.y/2),Random.Range(-size.z/2, size.z/2));
		
        Instantiate(ammoBox, transform.position + pos, Quaternion.identity);
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