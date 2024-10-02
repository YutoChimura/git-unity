using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 0.03f;    // 移動値

    //---------------------------
    //          追加
    public GameObject BulletObj;        // 弾のゲームオブジェクト
    //---------------------------

    Vector3 bulletPoint;                // 弾の位置
    Vector3 bulletPoint1;
    Vector3 bulletPoint2;
    // Start is called before the first frame update
    void Start()
    {
        //弾の発射位置取得
        bulletPoint = transform.Find("BulletPoint").localPosition;
        bulletPoint1 = transform.Find("BulletPoint1").localPosition;
        bulletPoint2 = transform.Find("BulletPoint2").localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // 横(Ⅹ)方向の入力
        float fHorizontalInput = Input.GetAxisRaw("Horizontal");
        // 縦(Ｙ)方向の入力
        float fVerticalInput = Input.GetAxisRaw("Vertical");

        // 位置を更新
        float add_x = fHorizontalInput * MoveSpeed;
        float add_y = fVerticalInput * MoveSpeed;
        transform.Translate(add_x, add_y, 0);

        // ボタンを押したとき
        if (Input.GetButtonDown("Fire1"))
        {
            // 弾の生成
            Instantiate(BulletObj, transform.position + bulletPoint, Quaternion.identity);
            Instantiate(BulletObj, transform.position + bulletPoint1, Quaternion.identity);
            Instantiate(BulletObj, transform.position + bulletPoint2, Quaternion.identity);
        }
    }
}