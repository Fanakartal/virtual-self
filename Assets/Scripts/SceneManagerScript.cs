using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public float timeCounter;
    public int nextSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeCounter -= Time.fixedDeltaTime;

        if (timeCounter < 0.0f)
            SceneManager.LoadScene(nextSceneIndex);
    }
}
