using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HP顯示判斷 : MonoBehaviour
{
    int HP顯示;  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       HP顯示 = GameObject.Find("貝爾(戰鬥用)").GetComponent<Bear>().HP;
       GetComponent<TMP_Text>().text = HP顯示.ToString();
    }
}
