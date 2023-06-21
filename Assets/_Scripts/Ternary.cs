using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

namespace Zef.TutoUnityFr
{
    public class Ternary : MonoBehaviour
    {

        public int x = 20;

        public int y = 10;
        // Start is called before the first frame update
        void Start()
        {
            /*if (x > y)
            {
                Debug.Log("x est supérieur à y");
            }
            else if (x < y)
            {
                Debug.Log("x est inférieur à y");
            }
            else
            {
                Debug.Log("x est égal à y");
            }*/

            string result = x > y ? "x est supérieur à y" :
                x < y ? "x est inférieur à y" :
                x == y ? "x est égal à y" : "Pas de résultat";
            Debug.Log(result);
            
           
        }

        // Update is called once per frame
        void Update()
        {
            /*
            switch (x.CompareTo(y))
            {
                case 1:
                    Debug.Log("x est supérieur à y");
                    break;
                case -1:
                    Debug.Log("x est inférieur à y");
                    break;
                default:
                    Debug.Log("x est égal à y");
                    break;
            }*/
        }

        
    }
}
