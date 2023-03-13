using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AN顯示判斷4 : MonoBehaviour
{
    float AN顯示;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AN顯示 = GameObject.Find("艾絲(戰鬥用)").GetComponent<Aiz>().憤怒值百分比;
        GetComponent<TMP_Text>().text = AN顯示.ToString() + "%";
    }
}