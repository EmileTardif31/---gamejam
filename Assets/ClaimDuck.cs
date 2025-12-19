using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System.Linq;

public class ClaimDuck : MonoBehaviour
{
    [SerializeField] private GameObject canardConcerné;
    [SerializeField] private string canardObtenu;
    [SerializeField] private AudioSource bravo;
    [SerializeField] InfosCanards _infosCanards;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        canardConcerné.SetActive(false);
        // bravo.Play();
        
        SetCanardViaReflection(canardObtenu);
    }

    void SetCanardViaReflection(string nomDuCanard)
    {
        FieldInfo field = typeof(InfosCanards)
            .GetFields(BindingFlags.Public | BindingFlags.Instance)
            .FirstOrDefault(f =>
                f.FieldType == typeof(bool) &&
                f.Name == nomDuCanard
            );

        if (field == null)
        {
            Debug.LogError($"Canard '{nomDuCanard}' introuvable dans InfosCanards");
            return;
        }
        else
        {
            field.SetValue(_infosCanards, true);
        }

        // bool boolVar = field.GetValue(_infosCanards) as bool;

        // if (boolVar == null)
        // {
        //     Debug.LogError($"'{nomDuCanard}' n'est pas un BoolVariable");
        //     return;
        // }

        // boolVar.Value = true;
    }
}
