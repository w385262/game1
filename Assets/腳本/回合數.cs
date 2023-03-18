using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 回合數 : MonoBehaviour
{
    public int 敵方回合數 = 0;
    public int 我方回合數 = 0;
    
    public bool 我方可動作 = false;
    public bool 敵方可動作 = false;


    public bool 我方動作中;
    public bool 敵方動作中;
    void Start()
    {
        我方動作中 = false;
        敵方動作中 = false;
}

    // Update is called once per frame
    void Update()
    {
        if ((我方回合數 <= 敵方回合數)&&(敵方動作中 = false))
        {
            我方可動作 = true;
        }
        else
        {
            我方可動作 = false;
        }

        if ((敵方回合數 <= 我方回合數) && (我方動作中 = false))
        {
            敵方可動作 = true;
        }
        else
        {
            敵方可動作 = false;
        }
    }
}
