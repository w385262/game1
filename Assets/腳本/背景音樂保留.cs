using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 背景音樂保留 : MonoBehaviour
{
    public float 背景音樂播放時間;
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        背景音樂播放時間 += Time.deltaTime;

        if (背景音樂播放時間 > 36f)
        {
            關閉音樂();
            
        }
        else
        {
            DontDestroyOnLoad(this);
        }
    }

    void 關閉音樂()

    {
        Destroy(GameObject.Find("序幕背景音樂"));
    }
}
