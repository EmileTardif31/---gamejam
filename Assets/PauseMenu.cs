using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private string _nomDeLaSceneAChargerApres;
    [SerializeField] private GameObject _self;
    [SerializeField] private bool canPause = true;
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            isPaused = !isPaused;
            _self.SetActive(isPaused);
        }
    }

    public void ChangerScenePause()
    {
        if (canPause)
        {
            SceneManager.LoadScene(_nomDeLaSceneAChargerApres);
        }
    }
}
