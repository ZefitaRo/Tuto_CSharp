using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zef.TutoUnityFr
{
    public class CoroutineTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(MyCoroutine());
        }

        IEnumerator MyCoroutine()
        {
            print("MyCoroutine commence son exécution.");
            yield return new WaitForSeconds(5);
            print("MyCoroutine a terminé son exécution.");
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
