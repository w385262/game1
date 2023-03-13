using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 場景控制1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("開啟後退開關", 0.3f);
        Invoke("開啟驚嘆號開關", 0.3f);
        Invoke("開始轉場", 4f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void 開啟後退開關()
    {
        GameObject.Find("米諾淘洛斯2").GetComponent<Animator>().SetBool("開始後退", true);
    }
    void 開啟驚嘆號開關()
    {
        GameObject.Find("驚嘆號").GetComponent<Animator>().SetBool("驚嘆號閃出開始", true);
        GameObject.Find("驚嘆號 2").GetComponent<Animator>().SetBool("驚嘆號閃出開始", true);
        GameObject.Find("驚嘆號 3").GetComponent<Animator>().SetBool("驚嘆號閃出開始", true);
        GameObject.Find("驚嘆號 4").GetComponent<Animator>().SetBool("驚嘆號閃出開始", true);
    }

    void 開始轉場()
    {
        SceneManager.LoadScene(9);
    }
}
