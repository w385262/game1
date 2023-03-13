using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;

public class 場景控制2 : MonoBehaviour
{
    [SerializeField] GameObject[] 所有狀態欄;
    public GameObject[] 戰鬥角色;

    
    void Start()
    {
        GameObject Aiz = GameObject.Find("艾絲(戰鬥用)");
        GameObject Bear = GameObject.Find("貝爾(戰鬥用");
        戰鬥角色 = GameObject.FindGameObjectsWithTag("Player");
        
        if (戰鬥角色.Contains(Aiz))
        {
            所有狀態欄[3].SetActive(true); //艾絲(Aiz) = 狀態欄4
        }
        if (戰鬥角色.Contains(Bear))
        {
            所有狀態欄[0].SetActive(true); //貝爾(Bear) = 狀態欄1
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
