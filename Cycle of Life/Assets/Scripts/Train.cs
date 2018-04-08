using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Fungus;

public class Train : MonoBehaviour {

    // Use this for initialization
    public string SceneName;
    public Flowchart flowchart;
    private bool havehelped;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        TrainCheck();
	}

    void TrainCheck()
    {
        havehelped = flowchart.GetBooleanVariable("givefood");
    }

    public void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        
        if((collision.gameObject.tag == "Player")&&(havehelped))
        {
            SceneManager.LoadScene("Stage3");
        }


        if ((collision.gameObject.tag == "Player") && (!havehelped))
        {
            SceneManager.LoadScene("Stage2");
        }

    }
}
