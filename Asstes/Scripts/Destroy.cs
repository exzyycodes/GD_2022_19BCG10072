using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPulpit : MonoBehaviour
{
    public float interval;
    public static float timex;

    void Update()
    {
        //uses interval into timex
        if (interval > 0){
            timex = interval;
            interval -=Time.deltaTime;
            timex -=Time.deltaTime;
        }
        else {
            enabled=false;
            //Checks for interaction with rigitbody, and destroys object
            gameObject.AddComponent<Rigidbody>();
            var x = gameObject.GetComponent<Rigidbody>();
            x.AddForce(new Vector3(0,-100.0f,0));
            Destroy(gameObject,1);
           
        }
    }

}