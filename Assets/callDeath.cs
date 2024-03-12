using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callDeath : MonoBehaviour
{
    Animator animator;
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
    }
}
