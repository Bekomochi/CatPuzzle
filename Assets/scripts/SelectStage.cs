using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectStage : MonoBehaviour
{
    [SerializeField] int StageNumber;

    //ステージを選択した時に出すパネル
    [SerializeField] GameObject SelectModePannel;

    //モードのボタン
    [SerializeField] Button RankingButton;//ランキングを表示するボタン
    [SerializeField] Button PlayButton;//ゲームをスタートするボタン

    // Start is called before the first frame update
    void Start()
    {
        SelectModePannel.SetActive(false);
        RankingButton = GetComponent<Button>();
        PlayButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ステージを選択したらシーンを読みこむ
    public void OnClickSelect()
    {
        SceneLoader.SetCurrentStage(StageNumber);

        if (StageNumber == 1)
        {
            SelectModePannel.SetActive(true);
        }
        if (StageNumber == 2)
        {
            SceneManager.LoadScene("UIScene");
        }
        if (StageNumber == 3)
        {
            SceneManager.LoadScene("UIScene");
        }
        if (StageNumber == 4)
        {
            SceneManager.LoadScene("UIScene");
        }
        if (StageNumber == 5)
        {
            SceneManager.LoadScene("UIScene");
        }
        if (StageNumber == 6)
        {
            SceneManager.LoadScene("UIScene");
        }
    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene("UIScene");
    }

    //public void OnClickRanking()
    //{
    //    SceneManager.LoadScene("Ranking_stage" + StageNumber);
    //}
}
