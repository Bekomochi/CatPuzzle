using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField] GameObject StartButton;//�^�C�g����ʂɏo���{�^��


    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            bool isLoaded = NetworkManager.Instance.LoadUserData();

            //if(!isLoaded)
            //{
            //    /*���[�U�[�f�[�^���ۑ�����Ă��Ȃ��ꍇ�͓o�^����
            //      [Guid]�́A128bit�̏d�����Ȃ������_���Ȓl�B
            //    �@�������O����͂�����Ȃ�AUI����擾����B*/
            //    StartCoroutine(NetworkManager.Instance.RegistUser(Guid.NewGuid().ToString(),result=>{
            //        //�o�^�I����A���̉�ʂɑJ��
            //        SceneManager.LoadScene("Samegame");

            //    }));
            //}
            //else
            //{
            //    //���[�U�[�f�[�^���ۑ�����Ă���ꍇ�́A���������Ɏ��̉�ʂɑJ��
            //    SceneManager.LoadScene("Samegame");

            //}

            OnClicRetry();
        }
    }

    void OnClicRetry()
    {
        SceneManager.LoadScene("Stage1");
    }
}
