using UnityEngine;
using System.IO;
public class MGPatcherControllVersion : MGPatcherClient.Core.MGPatcherControllVersion {

    public override string SetPath()
    {
     #if (UNITY_STANDALONE_WIN || UNITY_EDITOR)
        return Directory.GetParent(Application.dataPath).ToString();
      #elif UNITY_STANDALONE_OSX
        return = Application.dataPath + "/../..";
      #elif UNITY_STANDALONE_LINUX
        return Application.dataPath + "/../";
      #endif
    }


}
