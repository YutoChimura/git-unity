using Unity.VisualScripting;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 3.0f;                   // 移動値
    [SerializeField] Vector3 moveVec = new Vector3(-1, 0, 0);  // 移動方向

    GameObject PlayerObj = null;

    const float deleteDistance = 35 * 35;   // 削除距離

    private void Start()
    {
        // ヒエラルキービューにある player を取得
        PlayerObj = GameObject.Find("player");
    }
    void Update()
    {
        float add_move = moveSpeed * Time.deltaTime;
        transform.Translate(moveVec * add_move);
        float distance = (PlayerObj.transform.position - transform.position).sqrMagnitude;
        // 一定の距離が離れたら消す
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
