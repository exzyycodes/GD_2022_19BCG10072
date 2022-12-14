using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulpitSpawner : MonoBehaviour
{
    public GameObject mutta;
    public static float timeint = 2.5f;
    

    private void spawnCubes(Vector3 xloc){
        GameObject x = Instantiate(mutta) as GameObject;
        var r = new System.Random();
        int randomizer = r.Next(1,5);
        switch (randomizer){
            case 0:
                x.transform.position = xloc + new Vector3(10,0,0);
                x.tag = "currentPulpit";
                break;
            case 1:
                x.transform.position = xloc + new Vector3(-10,0,0);
                x.tag = "currentPulpit";
                break;
            case 2:
                x.transform.position = xloc + new Vector3(0,0,10);
                x.tag = "currentPulpit";
                break;
            case 3:
                x.transform.position = xloc + new Vector3(0,0,-10);
                x.tag = "currentPulpit";
                break;
        }
        
    }
    IEnumerator cubespawner(){
        while(true){
            yield return new WaitForSeconds(timeint);
            Vector3 bonk = GameObject.FindGameObjectWithTag("currentPulpit").transform.position;
            spawnCubes(bonk);
        }
    }
    void Start()
    {
        StartCoroutine(cubespawner());
    }

}
