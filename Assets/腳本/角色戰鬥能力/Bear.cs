using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    
    public int ���� = 1;
    public int HP�W�� = 30;
    public int MP�W�� = 10;
    public float ����� = 0;
    public int �g��� = 0;
    public float ����ȤW�� = 100;
    public int HP = 0;
    public int MP = 0;
    public float ����Ȧʤ���;

    void Start()
    {   
        ����� = 1;
        HP = HP�W��;
        MP = MP�W��;
        ����Ȧʤ��� = (����� / ����ȤW��) * 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
