using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finGundam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("finCombat", 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void finCombat(){
        // SceneManager.LoadScene("Fin");
    }
}
