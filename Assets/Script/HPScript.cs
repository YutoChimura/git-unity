using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HPscript : MonoBehaviour
{

    public int life = 100;


    public Slider hpBar;
    // Start is called before the first frame update
    void Start()
    {
        if (hpBar != null)
        {
            //HP�̐��l���f
            hpBar.value = life;
        }
    }
    public void Damage(int damage)
    {
        if (life <= 0) return;
        //����������_���[�W
        life -= damage;
        if (hpBar != null)
        {
            //��e���HP���f
            hpBar.value = life;
        }
    }
}