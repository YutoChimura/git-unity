using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 0.03f;    // �ړ��l

    //---------------------------
    //          �ǉ�
    public GameObject BulletObj;        // �e�̃Q�[���I�u�W�F�N�g
    //---------------------------

    Vector3 bulletPoint;                // �e�̈ʒu
    Vector3 bulletPoint1;
    Vector3 bulletPoint2;
    // Start is called before the first frame update
    void Start()
    {
        //�e�̔��ˈʒu�擾
        bulletPoint = transform.Find("BulletPoint").localPosition;
        bulletPoint1 = transform.Find("BulletPoint1").localPosition;
        bulletPoint2 = transform.Find("BulletPoint2").localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // ��(�])�����̓���
        float fHorizontalInput = Input.GetAxisRaw("Horizontal");
        // �c(�x)�����̓���
        float fVerticalInput = Input.GetAxisRaw("Vertical");

        // �ʒu���X�V
        float add_x = fHorizontalInput * MoveSpeed;
        float add_y = fVerticalInput * MoveSpeed;
        transform.Translate(add_x, add_y, 0);

        // �{�^�����������Ƃ�
        if (Input.GetButtonDown("Fire1"))
        {
            // �e�̐���
            Instantiate(BulletObj, transform.position + bulletPoint, Quaternion.identity);
            Instantiate(BulletObj, transform.position + bulletPoint1, Quaternion.identity);
            Instantiate(BulletObj, transform.position + bulletPoint2, Quaternion.identity);
        }
    }
}