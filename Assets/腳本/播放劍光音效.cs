using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 播放劍光音效 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("開始播放音效", 0.05f);


        Scene 當前場景 = SceneManager.GetActiveScene();
        int 當前場景編號 = 當前場景.buildIndex;

        if (當前場景編號 == 6 || 當前場景編號 == 7)
        {
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void 開始播放音效()
    {
        GetComponent<AudioSource>().Play();
    }
}
