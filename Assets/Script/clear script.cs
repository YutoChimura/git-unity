using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clearscript : MonoBehaviour
{
    //•¡”‚Ì“G‚ğŠÇ—
    private GameObject[] enemyBox;

    void Update()
    {
        //Enemyƒ^ƒO‚ğ’T‚·
        enemyBox = GameObject.FindGameObjectsWithTag("Enemy");

        //‚·‚×‚Ä“|‚µ‚½‚çƒNƒŠƒA‰æ–Ê‚Ö
        if (enemyBox.Length == 0)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}