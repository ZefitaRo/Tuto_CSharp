using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zef.TutoUnityFr
{
    public class ListTest : MonoBehaviour
    {
        public List<GameObject> mesObjets = new List<GameObject>();

        public GameObject objectToAdd;
        
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(maCoroutine());
        }

        IEnumerator maCoroutine()
        {
            Debug.Log("Ajout de l'objet dans la liste");
            mesObjets.Add(objectToAdd);

            yield return new WaitForSeconds(3f);
            
            Debug.Log("Supression de l'objet de la liste");
            mesObjets.Remove(objectToAdd);
        }

        // Update is called once per frame
        void Update()
        {
          
        }
    }
}
