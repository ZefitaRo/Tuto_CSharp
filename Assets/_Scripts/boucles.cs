using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zef.TutoUnityFr
{
    public class boucles : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            string[] textes = new string[3];

            textes[0] = "premier texte";
            textes[1] = "deuxième texte";
            textes[2] = "troisième texte";

            foreach (string item in textes)
            {
                Debug.Log(item);
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
