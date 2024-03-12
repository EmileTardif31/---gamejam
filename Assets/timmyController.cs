using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class timmyController : MonoBehaviour
{
    private Rigidbody _rb;
    private Animator animator;
    private float _mouvementHorizontal;
    private float _mouvementAvant;

    [SerializeField] private float _force = 1;
    [SerializeField] private float _forceRotation = 2;
    [SerializeField] private float _vitesse = 2;
    [SerializeField] private float _vitesseRotation = 2;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Bouger();
        // Animation();
    }

    void OnMove(InputValue value){
        Vector2 _touchesClavier = value.Get<Vector2>();
        _mouvementAvant = _touchesClavier.y;
        _mouvementHorizontal = _touchesClavier.x;

    }

    void Bouger(){
        // _rb.AddRelativeForce(Vector3.forward * _mouvementAvant * _force, ForceMode.Force);
        // _rb.AddRelativeTorque(Vector3.up * _mouvementHorizontal * _forceRotation, ForceMode.VelocityChange);
        Vector3 _direction = Vector3.forward * _vitesse * _mouvementAvant;
        _rb.velocity = _direction * _vitesse;
        _rb.velocity = transform.TransformDirection(_direction * _vitesse);


        Vector3 _tourneDeCombien = Vector3.up * _vitesseRotation * _mouvementHorizontal ;
Quaternion _degresEnQuaternion = Quaternion.Euler(_tourneDeCombien);
_rb.MoveRotation(_rb.rotation * _degresEnQuaternion);

    }

    // void Animation(){
    //     if(Input.GetKey("w")){
    //         animator.SetBool("isWalking", true);
            
    //     }
    //     if(!Input.GetKey("w")){
    //         animator.SetBool("isWalking", false);
    //         animator.SetBool("isRunning", false);
            
    //     }
    //     if(Input.GetKey(KeyCode.LeftShift)&&animator.GetBool("isWalking")==true){
    //         animator.SetBool("isRunning", true);
            
    //     }
    //     if(!Input.GetKey(KeyCode.LeftShift)&&animator.GetBool("isWalking")==true){
    //         animator.SetBool("isRunning", false);
            
    //     } 
    // }
}
