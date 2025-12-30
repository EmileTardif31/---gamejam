using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayRecord : MonoBehaviour
{
    [SerializeField] private string _nomDeLaSceneAChargerApres;
    private AudioSource _srcAudio;

    // Start is called before the first frame update
    void Start()
    {
        _srcAudio = GetComponent<AudioSource>();

        _srcAudio.Play();
        StartCoroutine(WaitForEnd());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitForEnd()
    {
        // On attend que le son commence vraiment
        yield return new WaitUntil(() => _srcAudio.isPlaying);

        // Puis on attend qu'il soit fini
        yield return new WaitUntil(() => !_srcAudio.isPlaying);

        SceneManager.LoadScene(_nomDeLaSceneAChargerApres);
        //test
    }
}
