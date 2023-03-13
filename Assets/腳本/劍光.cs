using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 劍光 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("切換場景7", 0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void 切換場景7()
    {
        SceneManager.LoadScene(7);
    }
}
