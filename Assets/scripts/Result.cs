using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    [SerializeField] public GameObject successesPanel;//ゲーム終了時に出すパネル
    [SerializeField] public GameObject failurePanel;//ゲーム終了時に出すパネル
    public static int gameScore;//スコアの変数

    // Start is called before the first frame update
    void Start()
    {
        gameScore = SamegameDirector.gameScore;

        //リザルト画面を最初は非表示に設定
        successesPanel.SetActive(false);
        failurePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameScore > 200)
        //{
        //    //ミッション成功時リザルト画面を表示
        //    successesPanel.SetActive(true);
        //}
        //else
        //{
        //    //ミッション失敗時リザルト画面を表示
        //    failurePanel.SetActive(true);
        //}
    }

    //public void ResultJudgment()
    //{
    //    if (gameScore > 200)
    //    {
    //        //ミッション成功時リザルト画面を表示
    //        successesPanel.SetActive(true);
    //    }
    //    else
    //    {
    //        //ミッション失敗時リザルト画面を表示
    //        failurePanel.SetActive(true);
    //    }
    //}
}
