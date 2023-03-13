using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 狀態欄1控制 : MonoBehaviour
{
    [SerializeField]GameObject[] 所有子物件;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void 關掉所有子物件()
    {
        foreach (GameObject obj in 所有子物件)
        {
            obj.SetActive(false);
        }
    }
}
