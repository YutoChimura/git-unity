using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagescript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        //������ꂽ��_���[�W��^����
        if (other.CompareTag("Player"))
        {
            var status = other.GetComponent<HPscript>();
            //�_���[�W�ʐݒ�
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