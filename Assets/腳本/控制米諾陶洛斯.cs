using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 控制米諾陶洛斯 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        米諾陶洛斯開始大吼();
        Invoke("米諾陶洛斯停止大吼", 4.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void 米諾陶洛斯開始大吼()
    {
        GameObject.Find("米諾淘洛斯").GetComponent<Animator>().SetBool("開始大吼", true);
    }
    void 米諾陶洛斯停止大吼()
    {
        GameObject.Find("米諾淘洛斯").GetComponent<Animator>().SetBool("開始大吼", false);
    }
}
