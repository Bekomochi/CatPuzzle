using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class UIDirector : MonoBehaviour
{
    //�ϐ��̐ݒ�
    float gameTimer; //�^�C�}�[

    //UI�Ɋւ���ϐ�
    [SerializeField] public TextMeshProUGUI scoreText;//�X�R�A
    [SerializeField] public TextMeshProUGUI timerText;//�Q�[������
    [SerializeField] public GameObject finishPanel;//�Q�[���I�����ɏo���p�l��
    [SerializeField] GameObject retryButton;//�Q�[���I�����ɏo���{�^��

    //�Q�[�����Ŏg�p������̂̕ϐ�
    int gameScore;//�X�R�A�̕ϐ�

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
        gameTimer -= Time.deltaTime;
        this.gameTimer = SamegameDirector.gameTimer;
        timerText.text = "" + (int)gameTimer;

        //�X�R�A�̕\�����X�V
        this.gameScore = SamegameDirector.gameScore;
        scoreText.text = "" + gameScore;

        //�Q�[���I��
        if (0 > gameTimer)
        {
            //���U���g��ʂ�\��
            finishPanel.SetActive(true);
        }
    }

    //���g���C�{�^���������ꂽ��
    public void OnClicRetry()
    {
        SceneManager.LoadScene("Stage1");
    }
}
