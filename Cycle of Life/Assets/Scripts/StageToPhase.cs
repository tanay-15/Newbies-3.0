using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

[CommandInfo("Stages","Stage Change","This will change the stage to phase")]
public class StageToPhase : Command {

    public string SceneName;
	public override void OnEnter()
    {
        stagetophase();
    }

    void stagetophase()
    {
        SceneManager.LoadScene(SceneName);
    }
}
