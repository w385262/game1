using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MP顯示判斷4 : MonoBehaviour
{
    int MP顯示;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MP顯示 = GameObject.Find("艾絲(戰鬥用)").GetComponent<Aiz>().MP;
        GetComponent<TMP_Text>().text = MP顯示.ToString();
    }
}
