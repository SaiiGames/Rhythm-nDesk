using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugGameManager : MonoBehaviour
{
    public bool play = false;
    public bool restart = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p") || play)
        {
            Conductor.Instance.StartSong();
            Time.timeScale = 1f;
            play = false;
        }

        if (Input.GetKeyDown("r") || restart) 
        {
            SceneManager.LoadScene ("MusicScore");
            restart = false;

        }
    }

    public void StartGame()
    {
        play = true;
    }
    
    public void RestartGame()
    {
        restart = true;
    }
}
