using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HP顯示判斷4 : MonoBehaviour
{
    int HP顯示;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HP顯示 = GameObject.Find("艾絲(戰鬥用)").GetComponent<Aiz>().HP;
        GetComponent<TMP_Text>().text = HP顯示.ToString();
    }
}
