using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    [SerializeField] public GameObject successesPanel;//�Q�[���I�����ɏo���p�l��
    [SerializeField] public GameObject failurePanel;//�Q�[���I�����ɏo���p�l��
    public static int gameScore;//�X�R�A�̕ϐ�

    // Start is called before the first frame update
    void Start()
    {
        gameScore = SamegameDirector.gameScore;

        //���U���g��ʂ��ŏ��͔�\���ɐݒ�
        successesPanel.SetActive(false);
        failurePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameScore > 200)
        //{
        //    //�~�b�V�������������U���g��ʂ�\��
        //    successesPanel.SetActive(true);
        //}
        //else
        //{
        //    //�~�b�V�������s�����U���g��ʂ�\��
        //    failurePanel.SetActive(true);
        //}
    }

    //public void ResultJudgment()
    //{
    //    if (gameScore > 200)
    //    {
    //        //�~�b�V�������������U���g��ʂ�\��
    //        successesPanel.SetActive(true);
    //    }
    //    else
    //    {
    //        //�~�b�V�������s�����U���g��ʂ�\��
    //        failurePanel.SetActive(true);
    //    }
    //}
}
