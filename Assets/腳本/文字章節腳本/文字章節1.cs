using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ��r���`1 : MonoBehaviour
{ 
private string ��r���e;
private Text ��r��J��m;
public float ���r�ɶ����j;
private bool ���r���ҥ�;
private float �p�ɾ�;
private int ��e���r��m = 0;

void Start()
{
    �p�ɾ� = 0;
    ���r���ҥ� = true;
    ���r�ɶ����j = Mathf.Max(0, ���r�ɶ����j);
    ��r��J��m = GetComponent<Text>();
    ��r���e = ��r��J��m.text;
    ��r��J��m.text = "";
}

// Update is called once per frame
void Update()
{
    ���r��();
}



private void ���r��()
{
    if (���r���ҥ�)
    {
        �p�ɾ� += Time.deltaTime;
        if (�p�ɾ� >= ���r�ɶ����j)
        {
            �p�ɾ� = 0;
            ��e���r��m++;
            ��r��J��m.text = ��r���e.Substring(0, ��e���r��m);

            if (��e���r��m >= ��r���e.Length)
            {
                ���r��off();
                Invoke("��������1", 3f);
            }
        }
    }
}

private void ���r��off()
{
    ���r���ҥ� = false;
    �p�ɾ� = 0;
    ��e���r��m = 0;
    ��r��J��m.text = ��r���e;

}

    private void ��������1()
    {
        SceneManager.LoadScene(1);
    }
}
