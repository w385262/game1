using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinosTaurus : MonoBehaviour
{
    public AudioClip[] 米諾陶洛斯音效庫;
    int Nowscene;
    void Start()
    {

        Nowscene = SceneManager.GetActiveScene().buildIndex;
        if (Nowscene == 9)
        {
            Invoke("大吼控制", 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
