using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    HPscript status;
    // Start is called before the first frame update
    void Start()
    {
        status = GetComponent<HPscript>();
    }
    // Update is called once per frame
    void Update()
    {
        //体力が無くなったらゲームオーバー画面へ
        if (status?.life <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

