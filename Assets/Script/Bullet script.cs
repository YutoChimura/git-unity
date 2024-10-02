using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Bulletscript : MonoBehaviour
{
    public float MoveSpeed = 20.0f;         // �ړ��l

    const float deleteDistance = 35 * 35;   // �폜����

    GameObject playerObj = null;     // �v���C���[�I�u�W�F�N�g

    // Start is called before the first frame update
    void Start()
    {
        // �q�G�����L�[�r���[�ɂ��� player ���擾
        playerObj = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        // �ʒu�̍X�V
        transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);

        float distance = (playerObj.transform.position - transform.position).sqrMagnitude;

        // ���̋��������ꂽ�����
        if (distance > deleteDistance)
        {
            Destroy(gameObject);
        }

    }
}
