using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MulchSceneLorder : MonoBehaviour
{
    SamegameDirector samegameD = new SamegameDirector();

    //UIに関する変数
    [SerializeField] TextMeshProUGUI scoreText;//スコア
    [SerializeField] TextMeshProUGUI timerText;//ゲーム時間
    [SerializeField] GameObject finishPanel;//ゲーム終了時に出すパネル
    [SerializeField] GameObject retryButton;//ゲーム終了時に出すパネル

    [SerializeField] float gameTimer; //タイマー

    //Start is called before the first frame update
    void Start()
    {
        //リザルト画面を最初は非表示に設定
        samegameD.finishPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //タイマーの表示を更新
        samegameD.timerText.text = "" + (int)samegameD.gameTimer;

        //ゲーム終了
        if (0 > samegameD.gameTimer)
        {
            //リザルト画面を表示
            samegameD.finishPanel.SetActive(true);

            //Update関数に入らないようにする
            enabled = false;

            //Updateから抜ける
            return;
        }

        //スコアの表示を更新
        samegameD.scoreText.text = "" + samegameD.gameScore;
    }

    private void Awake()
    {
        SceneManager.LoadScene("MulchScene", LoadSceneMode.Additive);
    }

    //リトライボタンを押されたら
    public void OnClicRetry()
    {
        SceneManager.LoadScene("Samegame");
    }
}
