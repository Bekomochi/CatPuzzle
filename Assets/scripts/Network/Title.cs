using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField] GameObject StartButton;//タイトル画面に出すボタン


    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            bool isLoaded = NetworkManager.Instance.LoadUserData();

            //if(!isLoaded)
            //{
            //    /*ユーザーデータが保存されていない場合は登録する
            //      [Guid]は、128bitの重複しないランダムな値。
            //    　もし名前を入力させるなら、UIから取得する。*/
            //    StartCoroutine(NetworkManager.Instance.RegistUser(Guid.NewGuid().ToString(),result=>{
            //        //登録終了後、次の画面に遷移
            //        SceneManager.LoadScene("Samegame");

            //    }));
            //}
            //else
            //{
            //    //ユーザーデータが保存されている場合は、何もせずに次の画面に遷移
            //    SceneManager.LoadScene("Samegame");

            //}

            OnClicRetry();
        }
    }

    void OnClicRetry()
    {
        SceneManager.LoadScene("Stage1");
    }
}
