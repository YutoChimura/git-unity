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
            //HPĚl˝f
            hpBar.value = life;
        }
    }
    public void Damage(int damage)
    {
        if (life <= 0) return;
        //˝Á˝ç_[W
        life -= damage;
        if (hpBar != null)
        {
            //íeăĚHP˝f
            hpBar.value = life;
        }
    }
}