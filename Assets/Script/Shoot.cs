using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    private Animator _anim;


    // Use this for initialization
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private float bulletSpeed;

     void Update () {
     
         if (Input.touchCount > 0) {
 
             if (Input.GetTouch (0).phase == TouchPhase.Began) {
 
                 Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                 Vector2 dir = touchPos - (new Vector2(transform.position.x, transform.position.y));
                 dir.Normalize ();
                 GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity);
                 bullet.GetComponent<Rigidbody2D> ().velocity = dir * bulletSpeed;
                 Debug.Log("PEW PEW");
                 
             }
         }
     }

    
}


