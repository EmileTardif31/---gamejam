using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class callDeath : MonoBehaviour
{
    Animator animator;
    [SerializeField] private string _nomDeLaSceneAChargerApres;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Invoke("Die",10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Die(){
        animator.SetBool("aboutToDie", true);
        Invoke("Switch",3);
    }

    void Switch()
    {
        SceneManager.LoadScene(_nomDeLaSceneAChargerApres);        
    }
}
