using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class DaysCount : MonoBehaviour {

    // Use this for initialization
    int days ;

    public Text DaysText;
    private int dayct;
    public GameObject player;
    [SerializeField]
    private ObjectPickup OP;

    void Awake()
    {
        OP = player.GetComponent<ObjectPickup>();
    }
	void Start () {
        

        days = 1;
        DaysText = GetComponent<Text>();
        dayct = PlayerPrefs.GetInt("DAYS", 1);
       
    }
	
	// Update is called once per frame
	void Update () {

      
        if (OP.endFlag)
        {
            dayct += 1;
            if (dayct >= 3)
            {
                PlayerPrefs.DeleteKey("DAYS");
                dayct = 1;
            }

            OP.endFlag = false;
            SceneManager.LoadScene("Phase1");
        }

        DaysText.text = "Days: "+ dayct.ToString();
        PlayerPrefs.SetInt("DAYS", dayct);
        //PlayerPrefs.Save();
    }

    void SetDayCt(int dayct)
    {
        Debug.Log("Days " + dayct);
        
    }

    
}
