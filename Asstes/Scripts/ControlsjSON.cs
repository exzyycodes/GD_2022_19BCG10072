using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ControlsjSON : MonoBehaviour
{
    public string jsonURL;

    public GameObject doofus;
    public GameObject Pulpit;

    private Movement move;

    public float max_Time = 0;
     public float min_Time = 0;

    public float PulpitDestTime = 0;
    public float rTime =0;
    // Start is called before the first frame update
    void Start()
    
    {
        
         move = player.GetComponent<Movement>();
        StartCoroutine(getData());
    }

    IEnumerator getData()
    {
            processJsonData(_www.text);
       
    }
    private void processJsonData(string _url)
    {
        JsonTest data = JsonUtility.FromJson<JsonTest>(_url);
        Debug.Log(data.pulpit_data.pulpit_spawn_time);
        movement.speed = data.player_data.speed;
        max_Time = data.pulpit_data.max_pulpit_destroy_time;
        min_Time = data.pulpit_data.min_pulpit_destroy_time;
        PulpitDestTime = data.pulpit_data.pulpit_spawn_time;
        rTime = Random.Range(minTime, maxTime);
        Pulpit.SetActive(true);
        doofus.SetActive(true);
    }

  
}
