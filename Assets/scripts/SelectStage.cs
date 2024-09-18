using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStage : MonoBehaviour
{
    [SerializeField] int StageNumber;

    // Start is called before the first frame update
    void Start()
    {
        
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
            SceneManager.LoadScene("UIScene");
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
        //SceneManager.LoadScene("UIScene");
    }
}
