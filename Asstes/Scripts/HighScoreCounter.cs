using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HSDisplay : MonoBehaviour
{
    //final score is stored as integer value
        public int finalscore;
        public TMP_Text hsd;
 

    // Update is called once per frame
    void Update()
        //when destroy is triggered, final score is displayed in form of a string
    {   finalscore = TriggersDestroy.finalhighScore;
        hsd.SetText("Your Final Score: " + finalscore.ToString());
    }
}
