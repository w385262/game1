using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class 白畫面 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("切換場景8", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void 切換場景8()
    {
        SceneManager.LoadScene(8);
    }
}
