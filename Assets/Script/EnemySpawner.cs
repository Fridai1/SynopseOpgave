using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemy;

    [SerializeField]
    private float _walkingSpeed;

    // Use this for initialization
    void Start () {

		Spawn();
	}
	
	// Update is called once per frame
	void Update () {

		
	}

    private void Spawn()
    {
        Vector2 dir =  transform.right;
        dir.Normalize();
        GameObject enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        enemy.GetComponent<Rigidbody2D>().velocity = dir * -_walkingSpeed;
    }
}
