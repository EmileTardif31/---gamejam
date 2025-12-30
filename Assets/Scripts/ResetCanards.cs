using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCanards : MonoBehaviour
{
    [SerializeField] private InfosCanards _infosCanards;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetDeCanards()
    {
        _infosCanards.tutoFini = false;
        _infosCanards.UsineFinie = false;
        _infosCanards.ForetFinie = false;

        _infosCanards.blue = false;
        _infosCanards.black = false;
        _infosCanards.green = false;
        _infosCanards.pink = false;
        _infosCanards.yellow = false;
        _infosCanards.violet = false;
        _infosCanards.red = false;
    }
}
