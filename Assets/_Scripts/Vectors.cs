using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zef.TutoUnityFr
{
    public class Vectors : MonoBehaviour
    {
        private Vector3 direction = new Vector3(0, 1, 0);
        public GameObject cam1;
        public GameObject cam2;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(direction * Time.deltaTime);
        }


    }
}
