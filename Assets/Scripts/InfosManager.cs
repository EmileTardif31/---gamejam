using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfosManager : MonoBehaviour
{
    [SerializeField] private InfosCanards _infosCanards;
    
    void Start()
    {

       Invoke("Ereset",1);
    }

   void Update()
    {
        if (_infosCanards.black)
        {
            _infosCanards.tutoFini = true;
        }
        
        if (_infosCanards.green && _infosCanards.blue && _infosCanards.pink)
        {
            _infosCanards.UsineFinie = true;
        }

        if (_infosCanards.yellow && _infosCanards.violet && _infosCanards.red)
        {
            _infosCanards.ForetFinie = true;
        }
    }

    void Ereset()
    {
        if (!_infosCanards.tutoFini)
        {
            _infosCanards.black = false;
        }

        if (!_infosCanards.UsineFinie)
        {
            _infosCanards.green = false;
            _infosCanards.blue = false;
            _infosCanards.pink = false;
        }

        if (!_infosCanards.ForetFinie)
        {
            _infosCanards.yellow = false;
            _infosCanards.violet = false;
            _infosCanards.red = false;
        }
        
    
    }
}
