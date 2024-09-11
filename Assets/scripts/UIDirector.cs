using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class UIDirector : MonoBehaviour
{
    //UI�Ɋւ���ϐ�
    [SerializeField] public TextMeshProUGUI scoreText;//�X�R�A
    [SerializeField] public TextMeshProUGUI timerText;//�Q�[������
    [SerializeField] public GameObject finishPanel;//�Q�[���I�����ɏo���p�l��
    [SerializeField] GameObject retryButton;//�Q�[���I�����ɏo���{�^��
    [SerializeField] GameObject backButton;//�}�b�v�I����ʂɖ߂�{�^��

    //public Result result;

    // Start is called before the first frame update
    void Start()
    {
        //���U���g��ʂ��ŏ��͔�\���ɐݒ�
        finishPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //�^�C�}�[���X�V
        timerText.text = "" + (int)SamegameDirector.gameTimer;

        //�X�R�A�̕\�����X�V
        scoreText.text = "" + SamegameDirector.gameScore;

        //�Q�[���I��
        if (0 > SamegameDirector.gameTimer)
        {
            //���U���g��ʂ�\��
            finishPanel.SetActive(true);

            //result.ResultJudgment();
        }
    }

    //���g���C�{�^���������ꂽ��
    public void OnClicRetry()
    {
        SceneManager.LoadScene("UIScene");
    }

    //���g���C�{�^���������ꂽ��
    public void OnClicBack()
    {
        SceneManager.LoadScene("SelectStage");
    }
}
