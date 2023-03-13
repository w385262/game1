using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 貝爾 : MonoBehaviour
{
    
    public float 貝爾移動速度 =0f;
    public int 隨機秒數;
    public int 當前場景編號;
    public bool 是否移動 = false;
    public float 當前秒數 =0;
    void Start()
    {
        貝爾移動速度 = 2.8f;
        當前場景編號 = SceneManager.sceneCountInBuildSettings-1;
        隨機秒數 = Random.Range(3, 18);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (當前場景編號 == 8 && 是否移動 ==true)
        {
            當前秒數 += Time.deltaTime;
            if (隨機秒數 - 當前秒數 < 1)
            {
                切換至戰鬥場景();
            }       
        }



        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position -= new Vector3(貝爾移動速度 * Time.deltaTime, 0, 0);//人物向左移動
            播放移動動畫();
            停止播放向右移動動畫();
            停止播放向前移動動畫();
            停止播放向後移動動畫();
            是否移動 = true;


        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(貝爾移動速度 * Time.deltaTime, 0, 0);//人物向右移動
            播放向右移動動畫();
            停止播放移動動畫();
            停止播放向前移動動畫();
            停止播放向後移動動畫();
            是否移動 = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position -= new Vector3(0, 貝爾移動速度 * Time.deltaTime, 0);//人物向下移動
            播放向前移動動畫();
            停止播放移動動畫();
            停止播放向右移動動畫();
            停止播放向後移動動畫();
            是否移動 = true;

        }
        else if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += new Vector3(0, 貝爾移動速度 * Time.deltaTime, 0);//人物向上移動
            播放向後移動動畫();
            停止播放移動動畫();
            停止播放向右移動動畫();
            停止播放向前移動動畫();
            是否移動 = true;

        }
        else
        { 
         停止播放移動動畫();
         停止播放向右移動動畫();
         停止播放向前移動動畫();
         停止播放向後移動動畫();
         是否移動 = false;
        }
    }

    void 播放移動動畫()
    {
        GetComponent<Animator>().SetBool("向左移動",true);
    }
    void 停止播放移動動畫()
    {
        GetComponent<Animator>().SetBool("向左移動", false);
    }
    void 播放向右移動動畫()
    {
        GetComponent<Animator>().SetBool("向右移動", true);
    }
    void 停止播放向右移動動畫()
    {
        GetComponent<Animator>().SetBool("向右移動", false);
    }
    void 播放向前移動動畫()
    {
        GetComponent<Animator>().SetBool("向前移動", true);
    }
    void 停止播放向前移動動畫()
    {
        GetComponent<Animator>().SetBool("向前移動", false);
    }
    void 播放向後移動動畫()
    {
        GetComponent<Animator>().SetBool("向後移動", true);
    }
    void 停止播放向後移動動畫()
    {
        GetComponent<Animator>().SetBool("向後移動", false);
    }
    void 切換至戰鬥場景()
    {
        SceneManager.LoadScene("戰鬥畫面");
    }
}
