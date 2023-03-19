using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;
using UnityEngine.SceneManagement;

public class 米諾陶洛斯 : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera 震動攝影機;
    [SerializeField] AudioClip[] 音效管理;   
    public float 米諾陶洛斯移動速度 =0f; 
    public bool 允許移動 = false; //
    public float 米諾陶洛斯當前x位置;
    void Start()
    {
        米諾陶洛斯移動速度 = 6f;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        米諾陶洛斯當前x位置 = this.gameObject.transform.localPosition.x;

        if (允許移動 == true)
        {
            GetComponent<Animator>().SetBool("開始奔跑", true); //播放奔跑的動畫
            this.gameObject.transform.position += new Vector3(米諾陶洛斯移動速度 * Time.deltaTime, 0, 0);
            

        }
        if (米諾陶洛斯當前x位置 >2f) //移動到主角前面,然後關掉移動的bool
        {
            允許移動 =false;
            GetComponent<Animator>().SetBool("開始砍劈", true);
            Invoke("切換場景5", 2.5f);
            GetComponent<Animator>().SetBool("開始奔跑", false); //停止奔跑的動畫
            GameObject.Find("貝爾攝影機").GetComponent<貝爾攝影機>().切換為貝爾攝影機();

        }

    }

  

    void 切換()
    {
        StartCoroutine(切換為震動攝影機()); //startcoroutine可短暫呼叫一個程式
    }
    IEnumerator 切換為震動攝影機() //被startcoroutine呼叫的程式必須用ienumerator
    {
        震動攝影機.Priority = 20;
        yield return new WaitForSeconds(5f); //5秒後回到priorty5
        震動攝影機.Priority = 5;
        移動至主角面前();
      
    }

    private void 移動至主角面前()
    {
        允許移動 = true;
        
        
    }
    void 切換場景5()
    {
        SceneManager.LoadScene(5);
    }

     void 播放大吼音效()
    {
        GetComponent<AudioSource>().PlayOneShot(音效管理[0]);
        Invoke("播放緊張音效", 4.5f);
    }

    public void 播放緊張音效()
    {
        GameObject.Find("緊張氣氛音效").GetComponent<AudioSource>().Play();
    }
  
}
