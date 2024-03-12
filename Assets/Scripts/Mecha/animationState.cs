using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationState : MonoBehaviour
{
    Animator animator;
    [SerializeField] float _vitesse = 10;
    [SerializeField] float _vitesseRotation = 4;

    private int currentAttack;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();
        
        
    }

    private void Attack(){
        if(Input.GetKey("m")){
            animator.SetBool("isPunching", true);
        }

        if(Input.GetKey("n")){
            animator.SetBool("isKicking", true);
        }     
    }

    private void Move(){
       if(Input.GetKey("w")){
            animator.SetBool("isWalking", true);
            transform.Translate(Vector3.forward * _vitesse * Time.deltaTime * 1);
        }
        if(!Input.GetKey("w")){
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", false);
            transform.Translate(Vector3.forward * _vitesse * Time.deltaTime * 0);
        }

       if(Input.GetKey("a")){
            
            transform.Rotate(Vector3.up * _vitesseRotation * Time.deltaTime * -1);
        }
        if(!Input.GetKey("a")){
            
            transform.Rotate(Vector3.up * _vitesseRotation * Time.deltaTime * 0);
        }
       if(Input.GetKey("d")){
            
            transform.Rotate(Vector3.up * _vitesseRotation * Time.deltaTime * 1);
        }
        if(!Input.GetKey("d")){
            
            transform.Rotate(Vector3.up * _vitesseRotation * Time.deltaTime * 0);
        }
        if(Input.GetKey(KeyCode.LeftShift)&&animator.GetBool("isWalking")==true){
            animator.SetBool("isRunning", true);
            transform.Translate(Vector3.forward * _vitesse * Time.deltaTime * 2);
        }
        if(!Input.GetKey(KeyCode.LeftShift)&&animator.GetBool("isWalking")==true){
            animator.SetBool("isRunning", false);
            
        } 
    }

    
}
