using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinosTaurus : MonoBehaviour
{
    public AudioClip[] 米諾陶洛斯音效庫;
    int Nowscene;
    Vector3 起始位置;
    public float 戰鬥用米諾陶洛斯移動速度;
    public 回合數 回合控制;
    public int 目前回合數;

    void Start()
    {
        起始位置 = this.transform.position;
        Nowscene = SceneManager.GetActiveScene().buildIndex;
        目前回合數 = 回合控制.敵方回合數;
        戰鬥用米諾陶洛斯移動速度 = 5f;
        if (Nowscene == 9)
        {
            Invoke("大吼控制", 2f);
        }
    }

    void Update()
    {
        if (Nowscene == 9)
        {
            if ((回合控制.我方回合數 == 1) && (回合控制.敵方可動作 == true))
            {
                Invoke("普通攻擊", 2f);
            }
        }
        
    }

    void 大吼控制()
    {
        StartCoroutine(大吼());
    }
    IEnumerator 大吼()
    {
        GetComponent<Animator>().SetBool("開始大吼(戰鬥用)", true);
        GetComponent<AudioSource>().PlayOneShot(米諾陶洛斯音效庫[0]);
        yield return new WaitForSeconds(6f);
        GetComponent<Animator>().SetBool("開始大吼(戰鬥用)", false);

    }

    void 普通攻擊()
    {
        this.gameObject.transform.position += new Vector3(戰鬥用米諾陶洛斯移動速度* Time.deltaTime, 0, 0);
        GetComponent<Animator>().SetBool("開始奔跑(戰鬥用)", true);
        if (this.gameObject.transform.position.x > -1)
        {
            戰鬥用米諾陶洛斯移動速度 = 0;
            GetComponent<Animator>().SetBool("開始奔跑(戰鬥用)", false);
        }

        回合控制.敵方回合數++;
        if (回合控制.敵方回合數 - 目前回合數 > 1)
        {
            回合控制.敵方回合數 = 目前回合數 + 1;
        }



    }


}
