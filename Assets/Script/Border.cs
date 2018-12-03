using UnityEngine;

namespace Assets.Script
{
    public class Border : MonoBehaviour {

        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update ()
        {
		
        }

	
        void OnCollisionEnter2D(Collision2D Object)
        {
            Destroy(Object.gameObject);
            Debug.Log("Hit The Wall");
        
        }

    

    
    
    

    
    

    
    }
}
