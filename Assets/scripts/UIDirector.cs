using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class UIDirector : MonoBehaviour
{
    //変数の設定

    //UIに関する変数
    [SerializeField] public TextMeshProUGUI scoreText;//スコア
    [SerializeField] public TextMeshProUGUI timerText;//ゲーム時間
    [SerializeField] public GameObject finishPanel;//ゲーム終了時に出すパネル
    [SerializeField] GameObject retryButton;//ゲーム終了時に出すボタン

    //ゲーム内で使用するものの変数

    // Start is called before the first frame update
    void Start()
    {
        //リザルト画面を最初は非表示に設定
        finishPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //タイマーを更新
        timerText.text = "" + (int)SamegameDirector.gameTimer;

        //スコアの表示を更新
        scoreText.text = "" + SamegameDirector.gameScore;

        //ゲーム終了
        if (0 > SamegameDirector.gameTimer)
        {
            //リザルト画面を表示
            finishPanel.SetActive(true);
        }
    }

    //リトライボタンを押されたら
    public void OnClicRetry()
    {
        SceneManager.LoadScene("UIScene");
    }
}
