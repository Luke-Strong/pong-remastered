using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.IO;
using MGPatcherClient.Core;
public class RestartApp : MonoBehaviour {
#if !UNITY_WEBPLAYER&&!UNITY_WEBGL
    bool gameWasUpdated = false;
   
	// Use this for initialization
    public void GameWasUpdated()
 {
  gameWasUpdated = true;
  Invoke("ApplicationQuit", 2.0f);
 }

 private void ApplicationQuit()
 {
  Application.Quit();
 }
 void OnApplicationQuit() {
     string _PATH = "";
     string format = ".exe";
#if UNITY_STANDALONE_WIN
     _PATH = Directory.GetParent(Application.dataPath).ToString();
     format = ".exe";
#elif UNITY_STANDALONE_OSX
        _PATH = Application.dataPath + "/../..";
     format = ".app";
#elif UNITY_STANDALONE_LINUX
        _PATH = Application.dataPath + "/../";
     format = ".app";
#endif
     if (gameWasUpdated)
  Process.Start(Path.Combine(_PATH,MGPatcherControllVersion.instance.gameName+format));
 }
#endif

}
