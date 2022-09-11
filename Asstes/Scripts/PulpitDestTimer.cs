using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PupilSeconds : MonoBehaviour
{
    // Start is called before the first frame update
    
        public TMP_Text countdown;
    

    // Update is called once per frame
    void Update()
    {
        //Destroys the pulpit according to the timer runinng on text ui
        countdown.SetText(DestroyPulpit.di.ToString());
    }
}
