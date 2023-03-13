using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 文字章節1 : MonoBehaviour
{ 
private string 文字內容;
private Text 文字輸入位置;
public float 打字時間間隔;
private bool 打字機啟用;
private float 計時器;
private int 當前打字位置 = 0;

void Start()
{
    計時器 = 0;
    打字機啟用 = true;
    打字時間間隔 = Mathf.Max(0, 打字時間間隔);
    文字輸入位置 = GetComponent<Text>();
    文字內容 = 文字輸入位置.text;
    文字輸入位置.text = "";
}

// Update is called once per frame
void Update()
{
    打字機();
}



private void 打字機()
{
    if (打字機啟用)
    {
        計時器 += Time.deltaTime;
        if (計時器 >= 打字時間間隔)
        {
            計時器 = 0;
            當前打字位置++;
            文字輸入位置.text = 文字內容.Substring(0, 當前打字位置);

            if (當前打字位置 >= 文字內容.Length)
            {
                打字機off();
                Invoke("切換場景1", 3f);
            }
        }
    }
}

private void 打字機off()
{
    打字機啟用 = false;
    計時器 = 0;
    當前打字位置 = 0;
    文字輸入位置.text = 文字內容;

}

    private void 切換場景1()
    {
        SceneManager.LoadScene(1);
    }
}
