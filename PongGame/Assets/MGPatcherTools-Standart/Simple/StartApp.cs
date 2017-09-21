using UnityEngine;
using System.Collections;
using System.IO;
using System.Diagnostics;
public class StartApp : MonoBehaviour {
	public string launcherName="launcher.exe";
	bool quitfromscript = false;
	public void AppStart()
	{
		Invoke("ApplicationQuit", 2.0f);
	}
	private void ApplicationQuit()
	{
		quitfromscript = true;
		Application.Quit();

	}
	void OnApplicationQuit() {
		if (quitfromscript) {
			string _PATH = Directory.GetParent (Application.dataPath).ToString ();
			Process.Start (Path.Combine (_PATH, launcherName));
		}
	}
}
