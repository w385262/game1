using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 動畫事件 : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void 暫停遊戲與切換場景()
    {

        Invoke("切換場景3", 0.3f);

    }
    void 切換場景3()
    {
        SceneManager.LoadScene(3);
    }

   
}
