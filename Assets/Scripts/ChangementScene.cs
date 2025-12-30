using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementScene : MonoBehaviour
{
    [SerializeField] string nomDeLaSceneACharger;
    [SerializeField] string nomDeLaSceneActuelle;
    [SerializeField] string KeyTopress;
    [SerializeField] public InfosCanards _infosCanards;
    // Start is called before the first frame update
    void Start()
    {
        if (nomDeLaSceneActuelle == "usine")
        {
            _infosCanards.UsineFinie = false;
            _infosCanards.ForetFinie = false;
        }
        else if(nomDeLaSceneActuelle == "foret")
        {
            
            _infosCanards.ForetFinie = false;
        }
        else if(nomDeLaSceneActuelle == "tuto")
        {
            _infosCanards.tutoFini = false;
            _infosCanards.UsineFinie = false;
            _infosCanards.ForetFinie = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyTopress))
        {
            SceneManager.LoadScene(nomDeLaSceneACharger);
        }

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
