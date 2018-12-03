using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField]
    private TextMeshProUGUI _score;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

    // Denne metode er en test metode skal fjernes fra klassen og implementeres et andet sted, evt en game manager, hvor klassen her trigger en event on destroy.
    private void AddToScore()
    {
       
        int score = int.Parse(_score.text);
        score++;
        _score.SetText(score.ToString());
    }

    void OnCollisionEnter2D(Collision2D Object)
    {
        AddToScore();
        Destroy(Object.gameObject);
        Debug.Log("Hit The enemy");

    }
}
