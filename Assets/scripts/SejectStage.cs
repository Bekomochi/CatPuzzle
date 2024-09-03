using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SejectStage : MonoBehaviour
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

    public void OnClickSelect()
    {
        SceneLoader.SetCurrentStage(StageNumber);
        SceneManager.LoadScene("UIScene");

    }
}
