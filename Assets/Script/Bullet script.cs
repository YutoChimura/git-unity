using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Bulletscript : MonoBehaviour
{
    public float MoveSpeed = 20.0f;         // 移動値

    const float deleteDistance = 35 * 35;   // 削除距離

    GameObject playerObj = null;     // プレイヤーオブジェクト

    // Start is called before the first frame update
    void Start()
    {
        // ヒエラルキービューにある player を取得
        playerObj = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        // 位置の更新
        transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);

        float distance = (playerObj.transform.position - transform.position).sqrMagnitude;

        // 一定の距離が離れたら消す
        if (distance > deleteDistance)
        {
            Destroy(gameObject);
        }

    }
}
