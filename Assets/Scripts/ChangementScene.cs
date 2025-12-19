using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementScene : MonoBehaviour
{
    [SerializeField] string nomDeLaSceneACharger;
    [SerializeField] string nomDeLaSceneActuelle;
    [SerializeField] public InfosCanards _infosCanards;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoadSceneFromScriptable();
    }

    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(nomDeLaSceneACharger);
    }

    public void ChangerScene()
    {
        SceneManager.LoadScene(nomDeLaSceneACharger);
    }

    public void LoadSceneFromScriptable()
    {
        if (nomDeLaSceneActuelle == "usine")
        {
            if (_infosCanards.UsineFinie)
            {
                Invoke("ChangerScene", 4);
            }
        }
        else if(nomDeLaSceneActuelle == "foret")
        {
            if (_infosCanards.ForetFinie)
            {
                Invoke("ChangerScene", 4);
            }
        }
        else if(nomDeLaSceneActuelle == "tuto")
        {
            if (_infosCanards.tutoFini)
            {
                Invoke("ChangerScene", 4);
            }
        }
    }

    public void AppQuit()
    {
        Application.Quit();
    }
}
