using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushGameExit : MonoBehaviour
{
    //�Q�[���I��
    public void OnBUttun()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
