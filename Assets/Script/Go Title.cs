using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTitle : MonoBehaviour
{
    //�{�^���Ń^�C�g����ʂ�
    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title Scene");
    }
}
