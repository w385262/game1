using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MP顯示判斷 : MonoBehaviour
{
    int MP顯示;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MP顯示 = GameObject.Find("貝爾(戰鬥用)").GetComponent<Bear>().MP;
        GetComponent<TMP_Text>().text = MP顯示.ToString();
    }
}
