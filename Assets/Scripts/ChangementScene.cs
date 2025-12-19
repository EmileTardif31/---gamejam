using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementScene : MonoBehaviour
{
    [SerializeField] string nomDeLaScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(nomDeLaScene);
    }

    public void ChangerScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }

    public void AppQuit()
    {
        Application.Quit();
    }
}
