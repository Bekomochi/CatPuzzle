using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    static int currentStage;

    public static void SetCurrentStage(int stage)
    {
        currentStage = stage;
    }

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    void Awake()
    {
        SceneManager.LoadScene("Stage" + currentStage, LoadSceneMode.Additive);
    }
}
