using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class AssetLoader : MonoBehaviour
{
    [SerializeField] Slider loadSlider;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loding());//コルーチン始動
    }

    IEnumerator loding()
    {
        //カタログ更新処理
        var handle = Addressables.UpdateCatalogs();//最新のカタログ(json)を取得
        yield return handle;

        //ダウンロード実行
        AsyncOperationHandle downloadHandle = Addressables.DownloadDependenciesAsync("default", false);

        //ダウンロードが完了するまでスライダーのUIを更新
        while(downloadHandle.Status==AsyncOperationStatus.None)
        {
            loadSlider.value = downloadHandle.GetDownloadStatus().Percent * 100;//percent(パーセント)は0～1で取得
            yield return null;//1フレーム待つ
        }

        loadSlider.value = 100;
        Addressables.Release(downloadHandle);
        Addressables.Release(handle);

        //次のシーンに移動
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
