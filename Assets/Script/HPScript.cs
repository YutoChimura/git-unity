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
            //HPÇÃêîílîΩâf
            hpBar.value = life;
        }
    }
    public void Damage(int damage)
    {
        if (life <= 0) return;
        //ìñÇΩÇ¡ÇΩÇÁÉ_ÉÅÅ[ÉW
        life -= damage;
        if (hpBar != null)
        {
            //îÌíeå„ÇÃHPîΩâf
            hpBar.value = life;
        }
    }
}