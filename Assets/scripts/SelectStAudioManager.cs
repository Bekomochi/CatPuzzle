using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStAudioManager : MonoBehaviour
{
    [SerializeField] AudioClip BGM;//BGM

    AudioSource audioSource;//�T�E���h�Đ��p

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
