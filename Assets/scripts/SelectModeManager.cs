using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectModeManager : MonoBehaviour
{
    ////ステージを選択した時に出すパネル
    //[SerializeField] GameObject SelectModePannel;

    ////モードのボタン
    //[SerializeField] GameObject RankingButton;//ランキングを表示するボタン
    //[SerializeField] GameObject StartButton;//ゲームをスタートするボタン

    // Start is called before the first frame update
    void Start()
    {
        //SelectModePannel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ステージを選択したらパネルを表示
    //public void OnClicPopup()
    //{
    //    SelectModePannel.SetActive(true);
    //}

    ////[遊ぶ]を押したらゲーム画面に遷移
    //public void OnClickPlay()
    //{

    //}

    ////[ランキング]を押したらランキング画面に遷移
    //public void OnClickRanking()
    //{

    //}
}
