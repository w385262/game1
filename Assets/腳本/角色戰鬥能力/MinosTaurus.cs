using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinosTaurus : MonoBehaviour
{
    public AudioClip[] �̿ճ��������Įw;
    int Nowscene;
    void Start()
    {

        Nowscene = SceneManager.GetActiveScene().buildIndex;
        if (Nowscene == 9)
        {
            Invoke("�j�q����", 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void �j�q����()
    {
        StartCoroutine(�j�q());
    }
    IEnumerator �j�q()
    {
        GetComponent<Animator>().SetBool("�}�l�j�q(�԰���)", true);
        GetComponent<AudioSource>().PlayOneShot(�̿ճ��������Įw[0]);
        yield return new WaitForSeconds(6f);
        GetComponent<Animator>().SetBool("�}�l�j�q(�԰���)", false);
       
    }
}
