using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustPick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            Destroy(this.gameObject);
            /*if (Input.GetMouseButtonDown(0))
            {
                Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
                if (hit.collider != null)
                {
                    //object gets destroyed
                    //set up a variable before destroying for player inventory system
                    Destroy(hit.collider.gameObject);
                    
                    
           
            
                }
            }*/
         
        }
    }
}
