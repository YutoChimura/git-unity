using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    HPscript enemystatus;

    public ShootingEnemy shootingenemy;
    private void Start()
    {
        enemystatus = GetComponent<HPscript>();
    }
    // Update is called once per frame
    void Update()
    {
        //敵が弾を撃つ関数呼び出し
        shootingenemy.Shot();
        //体力が0になったら消滅
        if (enemystatus?.life <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // 当たったのがプレイヤーの弾
        if (other.gameObject.CompareTag("player_bullet"))
        {
            // 弾を消す
            Destroy(other.gameObject);
        }
    }
}