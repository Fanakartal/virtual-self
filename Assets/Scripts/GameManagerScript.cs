using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    private float waitTime = 10.0f;
    //public bool isWaitingStructure = false; 

    public int nextScene;
    
    // Start is called before the first frame update
    void Start()
    {
        /*if(isWaitingStructure)
        {
            if(SceneManager.GetActiveScene().buildIndex == 1)
                StartCoroutine(WaitLoadLevel(waitTime, 4));
            else if (SceneManager.GetActiveScene().buildIndex == 2)
                StartCoroutine(WaitLoadLevel(waitTime, 5));
            else if (SceneManager.GetActiveScene().buildIndex == 3)
                StartCoroutine(WaitLoadLevel(waitTime, 6));
            else if (SceneManager.GetActiveScene().buildIndex == 7)
                StartCoroutine(WaitLoadLevel(waitTime, 10));
            else if (SceneManager.GetActiveScene().buildIndex == 8)
                StartCoroutine(WaitLoadLevel(waitTime, 11));
            else if (SceneManager.GetActiveScene().buildIndex == 9)
                StartCoroutine(WaitLoadLevel(waitTime, 12));
        }*/
            
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
            GetScene(nextScene);
    }

    public void GetScene(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private IEnumerator WaitLoadLevel(float w, int sceneTo)
    {
        yield return new WaitForSeconds(w);

        SceneManager.LoadScene(sceneTo);
    }
}
