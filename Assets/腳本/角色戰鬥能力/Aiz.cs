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

    public int ���� = 60;
    public int HP�W�� = 8000;
    public int MP�W�� = 4000;
    public float ����� = 0;
    public int �g��� = 85000;
    public float ����ȤW�� = 100;
    public int HP = 0;
    public int MP = 0;
    public float ����Ȧʤ���;
    public float �����O = 2000;
    public float ���m�O = 1500;
    [SerializeField] Slider ���A��4��HP���Y����;
    [SerializeField] Slider ���A��4��MP���Y����;
    [SerializeField] Slider ���A��4��AN���Y����;
    public int �C���ɶ�Int;
    public float �C���ɶ�Float;
    GameObject ���S��;
    public GameObject �ۦ����;
    TextMeshProUGUI �ۦ��W��;
    public GameObject �ۦ����A���;
    TextMeshProUGUI �ۦ����A����;
    public �^�X�� �^�X����;
    public int RountCount = 0 ;


    int Nowscene;
    void Start()
    {
        
        ���S�� = transform.Find("���S��1").gameObject;
        ����� = 50;
        HP = HP�W��;
        MP = MP�W��;
        ����Ȧʤ��� = (����� / ����ȤW��) * 100;
        ���A��4��HP���Y����.maxValue = HP�W��;
        ���A��4��MP���Y����.maxValue = MP�W��;
        Nowscene = SceneManager.GetActiveScene().buildIndex;
        if (Nowscene == 9)
        {
            Invoke("�C����", 13f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ���A��4��HP���Y����.value = HP;
        ���A��4��MP���Y����.value = MP;
        ���A��4��AN���Y����.value = ����Ȧʤ���;

        �C���ɶ�Float += Time.deltaTime;
        �C���ɶ�Int = (int)�C���ɶ�Float;
        RountCount = �^�X����.�ڤ�^�X��;
        
    }

    void �C����()
    {
        �^�X����.�ڤ�^�X��++;
        �^�X����.�ڤ�ʧ@�� = true;
        StartCoroutine(��ܩۦ��I��());
        StartCoroutine(�C���ޮĪG());
        �ۦ��W�� = GameObject.Find("�ۦ��W��").GetComponent<TextMeshProUGUI>();
        �ۦ��W��.text = "�C����";
        GetComponent<Animator>().SetBool("�C����", true);
        �ܷt();
        Invoke("�C���ޥ��S�ıҥ�", 0.5f);
        Invoke("�C���ޥ��S������", 2.8f);
        Invoke("�C���ޭ����ҥ�", 2f);
        Invoke("��������ʵe", 7.8f);
        Invoke("�C���ޭ�������", 8f);
        Invoke("�ܫG", 8f);
        Invoke("��������", 8.3f);
        Invoke("�C���޵���", 8.5f);
        Invoke("�ʧ@����", 8.5f);
        MP -= 200;
    }

    void �C���޵���()
    {
        StartCoroutine(��ܩۦ����A�I��());
        �ۦ����A���� = GameObject.Find("�ۦ����A").GetComponent<TextMeshProUGUI>();
        �ۦ����A����.text = "�㵷���m�O�W��50%";
    }
    void �C���ޥ��S�ıҥ�()
    {

        if (���S�� != null)
        {
            ���S��.SetActive(true);
        }
        else
        {
            Debug.Log("�S�������S��1");
        }

    }
    void �C���ޥ��S������()
    {
        ���S��.SetActive(false);
    }
    void �C���ޭ����ҥ�()
    {
        GetComponent<Animator>().SetBool("�C����2", true);

        GameObject �C���� = transform.Find("�C����").gameObject;
        if (�C���� != null)
        {
            �C����.SetActive(true);
        }
        else
        {
            Debug.Log("�S�����C����");
        }
    }
    void �C���ޭ�������()
    {
        GetComponent<Animator>().SetBool("�C����", false);
        GameObject �C���� = transform.Find("�C����").gameObject;
        if (�C���� != null)
        {
            �C����.SetActive(false);
        }
        else
        {
            Debug.Log("�S�����C����");
        }
    }

    void �ܷt()
    {
        GameObject.Find("���t�վ��").GetComponent<Image>().color = new Color(0, 0, 0, 0.4f);

    }
    void �ܫG()
    {
        GameObject.Find("���t�վ��").GetComponent<Image>().color = new Color(0, 0, 0, 0);

    }

    void ��������ʵe()
    {
        GameObject ���� = transform.Find("�C���ޥ���").gameObject;
        if (���� != null)
        {
            ����.SetActive(true);
        }
        else
        {
            Debug.Log("�S�����C���ޥ���");
        }
        GetComponent<Animator>().SetBool("����", true);
        Invoke("����2", 0.3f);
    }

    void ����2()
    {
        GetComponent<Animator>().SetBool("����2", true);
    }
    void ��������()
    {
        GameObject ���� = transform.Find("�C���ޥ���").gameObject;
        if (���� != null)
        {
            ����.SetActive(false);
        }
        else
        {
            Debug.Log("�S�����C���ޥ���");
        }

    }
    IEnumerator ��ܩۦ��I��()
    {
        �ۦ����.SetActive(true);
        yield return new WaitForSeconds(5f);
        �ۦ����.SetActive(false);
    }
    IEnumerator ��ܩۦ����A�I��()
    {
        �ۦ����A���.SetActive(true);
        yield return new WaitForSeconds(3f);
        �ۦ����A���.SetActive(false);
    }
    IEnumerator �C���ޮĪG()
    {
        ���m�O *= 1.5f;
        yield return new WaitUntil(()=> RountCount>=3);
        ���m�O /= 1.5f;

    }

    void �ʧ@����()
    {
        �^�X����.�ڤ�ʧ@�� = false;
        
    }
}
