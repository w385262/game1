using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinosTaurus : MonoBehaviour
{
    public AudioClip[] �̿ճ��������Įw;
    int Nowscene;
    Vector3 �_�l��m;
    public float �԰��Φ̿ճ��������ʳt��;
    public �^�X�� �^�X����;
    public int �ثe�^�X��;

    void Start()
    {
        �_�l��m = this.transform.position;
        Nowscene = SceneManager.GetActiveScene().buildIndex;
        �ثe�^�X�� = �^�X����.�Ĥ�^�X��;
        �԰��Φ̿ճ��������ʳt�� = 5f;
        if (Nowscene == 9)
        {
            Invoke("�j�q����", 2f);
        }
    }

    void Update()
    {
        if (Nowscene == 9)
        {
            if ((�^�X����.�ڤ�^�X�� == 1) && (�^�X����.�Ĥ�i�ʧ@ == true))
            {
                Invoke("���q����", 2f);
            }
        }
        
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

    void ���q����()
    {
        this.gameObject.transform.position += new Vector3(�԰��Φ̿ճ��������ʳt��* Time.deltaTime, 0, 0);
        GetComponent<Animator>().SetBool("�}�l�b�](�԰���)", true);
        if (this.gameObject.transform.position.x > -1)
        {
            �԰��Φ̿ճ��������ʳt�� = 0;
            GetComponent<Animator>().SetBool("�}�l�b�](�԰���)", false);
        }

        �^�X����.�Ĥ�^�X��++;
        if (�^�X����.�Ĥ�^�X�� - �ثe�^�X�� > 1)
        {
            �^�X����.�Ĥ�^�X�� = �ثe�^�X�� + 1;
        }



    }


}
