using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Animator _anim;

    [SerializeField] private int _cooldown = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	   
		
	}

    public void ShootProjectile()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Debug.Log("X: "+touch.position.x);
            Debug.Log("Y: "+touch.position.y);
        }
        
        Debug.Log("PEW PEW");
        _anim = GetComponent<Animator>();
        _anim.SetBool("IsShooting", false);
        Thread.Sleep(_cooldown);
        _anim.SetBool("isShooting", true);
    }
}
