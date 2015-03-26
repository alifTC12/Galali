using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	public int delayTime;
	public string NextLevel;
	// Use this for initialization
	void Start () 
	{
		guiTexture.pixelInset = new Rect (0, 0, Screen.width, Screen.height);
		StartCoroutine (LoadNextScenes ());
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	IEnumerator LoadNextScenes()
	{
		yield return new WaitForSeconds (delayTime);
		if (NextLevel != "")
						Application.LoadLevel(NextLevel);
	}
}
