using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zef.TutoUnityFr
{
    public class Arraytest : MonoBehaviour
    {
        public GameObject[] monArray;

        private void Start()
        {
            monArray = GameObject.FindGameObjectsWithTag("Enemy");

            for (int i = 0; i < monArray.Length; i++)
            {
                Debug.Log("Désactivation de l'ennemi " + i);
                monArray[i].SetActive(false);
            }
        }
    }
}
