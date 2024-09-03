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
        StartCoroutine(loding());//�R���[�`���n��
    }

    IEnumerator loding()
    {
        //�J�^���O�X�V����
        var handle = Addressables.UpdateCatalogs();//�ŐV�̃J�^���O(json)���擾
        yield return handle;

        //�_�E�����[�h���s
        AsyncOperationHandle downloadHandle = Addressables.DownloadDependenciesAsync("default", false);

        //�_�E�����[�h����������܂ŃX���C�_�[��UI���X�V
        while(downloadHandle.Status==AsyncOperationStatus.None)
        {
            loadSlider.value = downloadHandle.GetDownloadStatus().Percent * 100;//percent(�p�[�Z���g)��0�`1�Ŏ擾
            yield return null;//1�t���[���҂�
        }

        loadSlider.value = 100;
        Addressables.Release(downloadHandle);
        Addressables.Release(handle);

        //���̃V�[���Ɉړ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
