using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class EndGame : MonoBehaviour {

    // Use this for initialization

    public Flowchart flowchart;
    private bool endgame;

	void Start () {

       
	}
	
	// Update is called once per frame
	void Update () {

        endgame = flowchart.GetBooleanVariable("endgame");
        if (endgame)
        {
            SceneManager.LoadScene("EndCredits");
        }
	}
}
