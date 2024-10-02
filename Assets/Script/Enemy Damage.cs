using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            var status = other.GetComponent<HPscript>();
            //ダメージ量設定
            status.Damage(25);
        }
    }
}
