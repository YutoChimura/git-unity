using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTitle : MonoBehaviour
{
    //ボタンでタイトル画面へ
    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title Scene");
    }
}
