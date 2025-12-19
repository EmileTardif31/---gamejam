using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayRecord : MonoBehaviour
{
    [SerializeField] private string _nomDeLaScene;
    [SerializeField] private AudioSource _trackAudio;

    // Start is called before the first frame update
    void Start()
    {
        _trackAudio.Play();
        StartCoroutine(WaitForEnd());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitForEnd()
    {
        // On attend que le son commence vraiment
        yield return new WaitUntil(() => _trackAudio.isPlaying);

        // Puis on attend qu'il soit fini
        yield return new WaitUntil(() => !_trackAudio.isPlaying);

        SceneManager.LoadScene(_nomDeLaScene);
        //test
    }
}
