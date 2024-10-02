using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultButtonSelector : MonoBehaviour
{
    [SerializeField]
    Button bUtton;
    // Start is called before the first frame update
    void Start()
    {
        bUtton.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
