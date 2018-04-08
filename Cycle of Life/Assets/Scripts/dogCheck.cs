using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
public class dogCheck : MonoBehaviour {

    public Flowchart flowchart;
    private bool dogcheck;
   

    void Start()
    {

    }

    void Update()
    {
        DogChecking();
    }

    void DogChecking()
    {
        dogcheck = flowchart.GetBooleanVariable("helped");
    }

    public void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {

        if((collision.gameObject.tag == "Player")&&(dogcheck))
        {
            SceneManager.LoadScene("Stage2");
        }

        if((collision.gameObject.tag == "Player") && (!dogcheck))
        {
            SceneManager.LoadScene("Stage1");
        }
    }
}
