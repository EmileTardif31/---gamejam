using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="InfosCanards", menuName = "SO/NouveauCanard")]
public class InfosCanards : ScriptableObject
{
   public bool black = false;
   public bool green = false;
   public bool blue = false;
   public bool pink = false;
   public bool yellow = false;
   public bool violet = false;
   public bool red = false;

   public bool UsineFinie = false;
   public bool ForetFinie = false;

   void Update()
    {
        if (green && blue && pink)
        {
            UsineFinie = true;
        }

        if (yellow && violet && red)
        {
            ForetFinie = true;
        }
    }
}
