using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaimDuck : MonoBehaviour
{
    [SerializeField] private GameObject canardConcerné;
    [SerializeField] private GameObject canardFinal;
    [SerializeField] private GameObject eventFinal;
    [SerializeField] private AudioSource bravo;
    // Start is called before the first frame update
    void Start()
    {
        canardFinal.SetActive(false);
        eventFinal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        canardConcerné.SetActive(false);
        canardFinal.SetActive(true);
        eventFinal.SetActive(true);
        bravo.Play();
        
    }
}
