using Unity.VisualScripting;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 3.0f;                   // �ړ��l
    [SerializeField] Vector3 moveVec = new Vector3(-1, 0, 0);  // �ړ�����

    GameObject PlayerObj = null;

    const float deleteDistance = 35 * 35;   // �폜����

    private void Start()
    {
        // �q�G�����L�[�r���[�ɂ��� player ���擾
        PlayerObj = GameObject.Find("player");
    }
    void Update()
    {
        float add_move = moveSpeed * Time.deltaTime;
        transform.Translate(moveVec * add_move);
        float distance = (PlayerObj.transform.position - transform.position).sqrMagnitude;
        // ���̋��������ꂽ�����
        if (distance > deleteDistance)
        {
            Destroy(gameObject);
        }
    }

    public void SetMoveSpeed(float _speed)
    {
        moveSpeed = _speed;
    }

    public void SetMoveVec(Vector3 _vec)
    {
        moveVec = _vec.normalized;
    }
}
