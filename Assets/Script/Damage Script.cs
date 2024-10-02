using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagescript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        //当たられたらダメージを与える
        if (other.CompareTag("Player"))
        {
            var status = other.GetComponent<HPscript>();
            //ダメージ量設定
            status.Damage(10);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}