using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clearscript : MonoBehaviour
{
    //�����̓G���Ǘ�
    private GameObject[] enemyBox;

    void Update()
    {
        //Enemy�^�O��T��
        enemyBox = GameObject.FindGameObjectsWithTag("Enemy");

        //���ׂē|������N���A��ʂ�
        if (enemyBox.Length == 0)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}