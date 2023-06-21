using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Zef.TutoUnityFr
{
    public class TestOnForms : MonoBehaviour
    {
        private GameObject maForme;
        // Start is called before the first frame update
        void Start()
        {
            maForme = this.gameObject;
            maForme.GetComponent<Renderer>().material.color = Color.blue;
        }

        // Update is called once per frame
        void Update()
        {
            

        }
    }
}
