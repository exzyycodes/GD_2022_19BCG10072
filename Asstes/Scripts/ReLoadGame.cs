using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReplayGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGame()
    {
        scoreCounter.totalScore=0;
        SceneManager.LoadScene("MainLevel");

    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("TitleMenu");
    }
}
