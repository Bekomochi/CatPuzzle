using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegistResponce : MonoBehaviour
{
    //JsonPropaty属性を付けて、jsonキー名を変数に割り当てる
    [JsonProperty("user_id")]
    public int UserID { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
