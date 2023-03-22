using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Aiz : MonoBehaviour
{

    public int 等級 = 60;
    public int HP上限 = 8000;
    public int MP上限 = 4000;
    public float 憤怒值 = 0;
    public int 經驗值 = 85000;
    public float 憤怒值上限 = 100;
    public int HP = 0;
    public int MP = 0;
    public float 憤怒值百分比;
    public float 攻擊力 = 2000;
    public float 防禦力 = 1500;
    [SerializeField] Slider 狀態欄4的HP伸縮控制;
    [SerializeField] Slider 狀態欄4的MP伸縮控制;
    [SerializeField] Slider 狀態欄4的AN伸縮控制;
    public int 遊戲時間Int;
    public float 遊戲時間Float;
    GameObject 光特效;
    public GameObject 招式顯示;
    TextMeshProUGUI 招式名稱;
    public GameObject 招式狀態顯示;
    TextMeshProUGUI 招式狀態說明;
    public 回合數 回合控制;
    public int RountCount = 0 ;


    int Nowscene;
    void Start()
    {
        
        光特效 = transform.Find("光特效1").gameObject;
        憤怒值 = 50;
        HP = HP上限;
        MP = MP上限;
        憤怒值百分比 = (憤怒值 / 憤怒值上限) * 100;
        狀態欄4的HP伸縮控制.maxValue = HP上限;
        狀態欄4的MP伸縮控制.maxValue = MP上限;
        Nowscene = SceneManager.GetActiveScene().buildIndex;
        if (Nowscene == 9)
        {
            Invoke("劍風盾", 13f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        狀態欄4的HP伸縮控制.value = HP;
        狀態欄4的MP伸縮控制.value = MP;
        狀態欄4的AN伸縮控制.value = 憤怒值百分比;

        遊戲時間Float += Time.deltaTime;
        遊戲時間Int = (int)遊戲時間Float;
        RountCount = 回合控制.我方回合數;
        
    }

    void 劍風盾()
    {
        回合控制.我方回合數++;
        回合控制.我方動作中 = true;
        StartCoroutine(顯示招式背景());
        StartCoroutine(劍風盾效果());
        招式名稱 = GameObject.Find("招式名稱").GetComponent<TextMeshProUGUI>();
        招式名稱.text = "劍風盾";
        GetComponent<Animator>().SetBool("劍風盾", true);
        變暗();
        Invoke("劍風盾光特效啟用", 0.5f);
        Invoke("劍風盾光特效關閉", 2.8f);
        Invoke("劍風盾風場啟用", 2f);
        Invoke("播放光環動畫", 7.8f);
        Invoke("劍風盾風場關閉", 8f);
        Invoke("變亮", 8f);
        Invoke("關閉光環", 8.3f);
        Invoke("劍風盾結束", 8.5f);
        Invoke("動作完成", 8.5f);
        MP -= 200;
    }

    void 劍風盾結束()
    {
        StartCoroutine(顯示招式狀態背景());
        招式狀態說明 = GameObject.Find("招式狀態").GetComponent<TextMeshProUGUI>();
        招式狀態說明.text = "艾絲防禦力上升50%";
    }
    void 劍風盾光特效啟用()
    {

        if (光特效 != null)
        {
            光特效.SetActive(true);
        }
        else
        {
            Debug.Log("沒有找到光特效1");
        }

    }
    void 劍風盾光特效關閉()
    {
        光特效.SetActive(false);
    }
    void 劍風盾風場啟用()
    {
        GetComponent<Animator>().SetBool("劍風盾2", true);

        GameObject 劍風盾 = transform.Find("劍風盾").gameObject;
        if (劍風盾 != null)
        {
            劍風盾.SetActive(true);
        }
        else
        {
            Debug.Log("沒有找到劍風盾");
        }
    }
    void 劍風盾風場關閉()
    {
        GetComponent<Animator>().SetBool("劍風盾", false);
        GameObject 劍風盾 = transform.Find("劍風盾").gameObject;
        if (劍風盾 != null)
        {
            劍風盾.SetActive(false);
        }
        else
        {
            Debug.Log("沒有找到劍風盾");
        }
    }

    void 變暗()
    {
        GameObject.Find("明暗調整用").GetComponent<Image>().color = new Color(0, 0, 0, 0.4f);

    }
    void 變亮()
    {
        GameObject.Find("明暗調整用").GetComponent<Image>().color = new Color(0, 0, 0, 0);

    }

    void 播放光環動畫()
    {
        GameObject 光環 = transform.Find("劍風盾光環").gameObject;
        if (光環 != null)
        {
            光環.SetActive(true);
        }
        else
        {
            Debug.Log("沒有找到劍風盾光環");
        }
        GetComponent<Animator>().SetBool("光環", true);
        Invoke("光環2", 0.3f);
    }

    void 光環2()
    {
        GetComponent<Animator>().SetBool("光環2", true);
    }
    void 關閉光環()
    {
        GameObject 光環 = transform.Find("劍風盾光環").gameObject;
        if (光環 != null)
        {
            光環.SetActive(false);
        }
        else
        {
            Debug.Log("沒有找到劍風盾光環");
        }

    }
    IEnumerator 顯示招式背景()
    {
        招式顯示.SetActive(true);
        yield return new WaitForSeconds(5f);
        招式顯示.SetActive(false);
    }
    IEnumerator 顯示招式狀態背景()
    {
        招式狀態顯示.SetActive(true);
        yield return new WaitForSeconds(3f);
        招式狀態顯示.SetActive(false);
    }
    IEnumerator 劍風盾效果()
    {
        防禦力 *= 1.5f;
        yield return new WaitUntil(()=> RountCount>=3);
        防禦力 /= 1.5f;

    }

    void 動作完成()
    {
        回合控制.我方動作中 = false;
        
    }
}
