using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 貝爾攝影機 : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera 攝影機;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    public void 切換為貝爾攝影機()
    {
        攝影機.Priority = 20;
        
    }
}
