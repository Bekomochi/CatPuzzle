using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;


public class Title : MonoBehaviour
{
    [SerializeField] GameObject StartButton;//タイトル画面に出すボタン
    [SerializeField] AudioClip BGM;//BGM
    AudioSource audioSource;//サウンド再生用
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //bool isLoaded = NetworkManager.Instance.LoadUserData();

            //if (!isLoaded)
            //{
            //    /*ユーザーデータが保存されていない場合は登録する
            //      [Guid]は、128bitの重複しないランダムな値。
            //    　もし名前を入力させるなら、UIから取得する。*/
            //    StartCoroutine(NetworkManager.Instance.RegistUser(Guid.NewGuid().ToString(), result =>
            //    {
            //        //登録終了後、次の画面に遷移
            //        SceneManager.LoadScene("SelectStage");
            //    }));
            //}
            //else
            //{
            //    //ユーザーデータが保存されている場合は、何もせずに次の画面に遷移
            //    SceneManager.LoadScene("SelectStage");

            //}

            //OnClicStart();
        }
    }

     public void OnClicStart()
    {
        var sequence = DOTween.Sequence();

        SceneManager.LoadScene("SelectStage");//マップ選択画面に遷移
    }
}
