using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	
    public void Exit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
        #elif UNITY_WEBPLAYER
        Application.OpenURL("http://google.com"); 
        #else
        Application.Quit(); 
        #endif

    }

}
