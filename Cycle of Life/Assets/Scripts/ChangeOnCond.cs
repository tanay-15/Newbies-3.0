using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class ChangeOnCond : MonoBehaviour {

    // Use this for initialization
    public GameObject player;
    [SerializeField] private ObjectPickup OP;
    public Flowchart flowchart;
    public string SceneName;
    private bool dogcheck;
	void Start () {


        OP = player.GetComponent<ObjectPickup>();
	}

 
	
	// Update is called once per frame
	void Update () {
        dogcheck = flowchart.GetBooleanVariable("helped");
        ChangeUp();
	}

    void ChangeUp()
    {

        if((OP.endFlag)&&(dogcheck))
        {
            SceneManager.LoadScene("Phase2");
            //OP.endFlag = false;
        }
        if ((OP.endFlag) && (!dogcheck))
        {
            SceneManager.LoadScene("FINAL SCENE 1");
            OP.endFlag = false;
        }

    }
}
