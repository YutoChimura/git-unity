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
        //“G‚ª’e‚ğŒ‚‚ÂŠÖ”ŒÄ‚Ño‚µ
        shootingenemy.Shot();
        //‘Ì—Í‚ª0‚É‚È‚Á‚½‚çÁ–Å
        if (enemystatus?.life <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // “–‚½‚Á‚½‚Ì‚ªƒvƒŒƒCƒ„[‚Ì’e
        if (other.gameObject.CompareTag("player_bullet"))
        {
            // ’e‚ğÁ‚·
            Destroy(other.gameObject);
        }
    }
}