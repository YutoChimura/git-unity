using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D.Animation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PushGameStart : MonoBehaviour
{
    public void OnStartButton()
    {
        StartCoroutine(LoadScene());
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // �V�[�������[�h����(�񓯊�)
    IEnumerator LoadScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MainScene");

        // ���[�h���܂��Ȃ玟�̃t���[����
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}

