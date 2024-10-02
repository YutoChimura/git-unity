using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushGameExit : MonoBehaviour
{
    //ÉQÅ[ÉÄèIóπ
    public void OnBUttun()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
