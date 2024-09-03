using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkManager : MonoBehaviour
{
    /*�ʐM������1�̃Q�[���I�u�W�F�N�g(�C���X�^���X)�ōs��
    >�V���O���g�����g��*/

    //get�v���p�e�B���Ăт��������񎞂ɃC���X�^���X�𐶐��Astatic�ŕێ�
    private static NetworkManager instance;

    const string API_BASE_URL = "https:// �`azure.com/api/";
    private int userID = 0;//�����̃��[�U�[ID
    private string userName = "";//���[�U�[ID;

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

    //���[�U�[�o�^����
    public IEnumerator RegistUser(string name, Action<bool> result)
    {
        //�T�[�o�[�ɑ��M����I�u�W�F�N�g���쐬
        RegistRequest requestData = new RegistRequest();
        requestData.Name = name;

        //�T�[�o�[�ɑ��M����I�u�W�F�N�g��json�ɕϊ�
        string json = JsonConvert.SerializeObject(requestData);
        requestData.Name = name;

        //���M
        UnityWebRequest request = UnityWebRequest.Post(API_BASE_URL + "users/store", json, "application");

        yield return request.SendWebRequest();//���ʂ���M����܂őҋ@
        bool isSuccess = false;
        if(request.result==UnityWebRequest.Result.Success && request.responseCode==200)
        {
            //�ʐM�����������ꍇ�A�Ԃ��Ă���json���I�u�W�F�N�g�ɕϊ�
            string resultJson = request.downloadHandler.text;//���X�|���X�{�f�B(json)�̕�������擾
            RegistResponce responce = JsonConvert.DeserializeObject<RegistResponce>(resultJson);//json���f�V���A���C�Y

            //�t�@�C���Ƀ��[�U�[ID��ۑ�
            this.userName = name;
            this.userID = responce.UserID;
            SaveUserData();
            isSuccess = true;
        }
        result?.Invoke(isSuccess);//�����ŌĂяo������result�������Ăяo��
    }

    //���[�U�[����ۑ�����
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

        //���[�J���t�@�C�����烆�[�U�[���ƃ��[�U�[ID���擾
        this.userID = saveData.UserID;
        this.userName = saveData.Name;

        return true;
    }
}
