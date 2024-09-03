using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkManager : MonoBehaviour
{
    /*通信処理を1つのゲームオブジェクト(インスタンス)で行う
    >シングルトンを使う*/

    //getプロパティを呼びだした初回時にインスタンスを生成、staticで保持
    private static NetworkManager instance;

    const string API_BASE_URL = "https:// ～azure.com/api/";
    private int userID = 0;//自分のユーザーID
    private string userName = "";//ユーザーID;

    public static NetworkManager Instance
    {
        get
        {
            if(instance==null)
            {
                GameObject gameObject = new GameObject("NetworkManager");
                instance = gameObject.AddComponent<NetworkManager>();
                DontDestroyOnLoad(gameObject);
            }
            return instance;
        }
    }

    //ユーザー登録処理
    public IEnumerator RegistUser(string name, Action<bool> result)
    {
        //サーバーに送信するオブジェクトを作成
        RegistRequest requestData = new RegistRequest();
        requestData.Name = name;

        //サーバーに送信するオブジェクトをjsonに変換
        string json = JsonConvert.SerializeObject(requestData);
        requestData.Name = name;

        //送信
        UnityWebRequest request = UnityWebRequest.Post(API_BASE_URL + "users/store", json, "application");

        yield return request.SendWebRequest();//結果を受信するまで待機
        bool isSuccess = false;
        if(request.result==UnityWebRequest.Result.Success && request.responseCode==200)
        {
            //通信が成功した場合、返ってきたjsonをオブジェクトに変換
            string resultJson = request.downloadHandler.text;//レスポンスボディ(json)の文字列を取得
            RegistResponce responce = JsonConvert.DeserializeObject<RegistResponce>(resultJson);//jsonをデシリアライズ

            //ファイルにユーザーIDを保存
            this.userName = name;
            this.userID = responce.UserID;
            SaveUserData();
            isSuccess = true;
        }
        result?.Invoke(isSuccess);//ここで呼び出し元のresult処理を呼び出す
    }

    //ユーザー情報を保存する
    private void SaveUserData()
    {
        SaveData saveData = new SaveData();
        saveData.Name = this.userName;
        saveData.UserID = this.userID;
        string json = JsonConvert.SerializeObject(saveData);
        var writer = new StreamWriter(Application.persistentDataPath + "/saveData.json");
        writer.Write(json);
        writer.Flush();
        writer.Close();
    }

    public bool LoadUserData()
    {
        if(!File.Exists(Application.persistentDataPath+"/saveData.json"))
        {
            return false;
        }
        var reader = new StreamReader(Application.persistentDataPath + "/saveData.json");
        string json = reader.ReadToEnd();
        reader.Close();
        SaveData saveData = JsonConvert.DeserializeObject<SaveData>(json);

        //ローカルファイルからユーザー名とユーザーIDを取得
        this.userID = saveData.UserID;
        this.userName = saveData.Name;

        return true;
    }
}
