using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;


public class Title : MonoBehaviour
{
    [SerializeField] GameObject StartButton;//�^�C�g����ʂɏo���{�^��
    [SerializeField] AudioClip BGM;//BGM
    AudioSource audioSource;//�T�E���h�Đ��p
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //bool isLoaded = NetworkManager.Instance.LoadUserData();

            //if (!isLoaded)
            //{
            //    /*���[�U�[�f�[�^���ۑ�����Ă��Ȃ��ꍇ�͓o�^����
            //      [Guid]�́A128bit�̏d�����Ȃ������_���Ȓl�B
            //    �@�������O����͂�����Ȃ�AUI����擾����B*/
            //    StartCoroutine(NetworkManager.Instance.RegistUser(Guid.NewGuid().ToString(), result =>
            //    {
            //        //�o�^�I����A���̉�ʂɑJ��
            //        SceneManager.LoadScene("SelectStage");
            //    }));
            //}
            //else
            //{
            //    //���[�U�[�f�[�^���ۑ�����Ă���ꍇ�́A���������Ɏ��̉�ʂɑJ��
            //    SceneManager.LoadScene("SelectStage");

            //}

            //OnClicStart();
        }
    }

     public void OnClicStart()
    {
        var sequence = DOTween.Sequence();

        SceneManager.LoadScene("SelectStage");//�}�b�v�I����ʂɑJ��
    }
}
