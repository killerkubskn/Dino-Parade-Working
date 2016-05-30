using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour {
	
	public void LoadLevelForest() {
		Application.LoadLevel ("LevelForest");
	}

	public void LoadLevelLava() {
		Application.LoadLevel ("LevelLava");
	}

	public void LoadLevelSnow(){
		Application.LoadLevel ("LevelSnow");
	}

	public void LoadLevelRock(){
		Application.LoadLevel ("LevelRock");
	}

	public void LoadLevelDeadland() {
		Application.LoadLevel ("LevelDeadland");
	}

	public void LoadLevelSelect() {
		Application.LoadLevel ("LevelSelect");
	}

	public void LoadLevelMainMenu() {
		Application.LoadLevel ("MainMenu");
	}

	public void LoadLevelOption() {
		Application.LoadLevel ("Option");
	}

	public void LoadLevelHelp() {
		Application.LoadLevel ("Help");
	}

	public void LoadLevelChangeName() {
		Application.LoadLevel ("ChangeName");
	}

	public void LoadLevelAchivements() {
		Application.LoadLevel ("Achivements");
	}

}
