using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MulchSceneLorder : MonoBehaviour
{
    SamegameDirector samegameD = new SamegameDirector();

    //UI�Ɋւ���ϐ�
    [SerializeField] TextMeshProUGUI scoreText;//�X�R�A
    [SerializeField] TextMeshProUGUI timerText;//�Q�[������
    [SerializeField] GameObject finishPanel;//�Q�[���I�����ɏo���p�l��
    [SerializeField] GameObject retryButton;//�Q�[���I�����ɏo���p�l��

    [SerializeField] float gameTimer; //�^�C�}�[

    //Start is called before the first frame update
    void Start()
    {
        //���U���g��ʂ��ŏ��͔�\���ɐݒ�
        samegameD.finishPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //�^�C�}�[�̕\�����X�V
        samegameD.timerText.text = "" + (int)samegameD.gameTimer;

        //�Q�[���I��
        if (0 > samegameD.gameTimer)
        {
            //���U���g��ʂ�\��
            samegameD.finishPanel.SetActive(true);

            //Update�֐��ɓ���Ȃ��悤�ɂ���
            enabled = false;

            //Update���甲����
            return;
        }

        //�X�R�A�̕\�����X�V
        samegameD.scoreText.text = "" + samegameD.gameScore;
    }

    private void Awake()
    {
        SceneManager.LoadScene("MulchScene", LoadSceneMode.Additive);
    }

    //���g���C�{�^���������ꂽ��
    public void OnClicRetry()
    {
        SceneManager.LoadScene("Samegame");
    }
}
