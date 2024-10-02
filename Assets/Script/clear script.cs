using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clearscript : MonoBehaviour
{
    //複数の敵を管理
    private GameObject[] enemyBox;

    void Update()
    {
        //Enemyタグを探す
        enemyBox = GameObject.FindGameObjectsWithTag("Enemy");

        //すべて倒したらクリア画面へ
        if (enemyBox.Length == 0)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}