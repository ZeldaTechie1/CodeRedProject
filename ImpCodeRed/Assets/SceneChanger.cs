using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	public void ChangeScene()
	{
		Application.LoadLevel ("Main");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
