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
        //�G���e�����֐��Ăяo��
        shootingenemy.Shot();
        //�̗͂�0�ɂȂ��������
        if (enemystatus?.life <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // ���������̂��v���C���[�̒e
        if (other.gameObject.CompareTag("player_bullet"))
        {
            // �e������
            Destroy(other.gameObject);
        }
    }
}