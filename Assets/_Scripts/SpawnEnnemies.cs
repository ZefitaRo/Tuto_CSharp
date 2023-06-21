using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zef.TutoUnityFr
{
    public class SpawnEnnemies : MonoBehaviour
    {
        [SerializeField] 
        private DifficultyModes currentDifficulty;
        
        // Start is called before the first frame update
        void Start()
        {
            Spawn((int)currentDifficulty);
        }

        void Spawn(int count)
        {
            for (int i = 0; i < count; i++)
            {
                GameObject enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);
                enemy.transform.parent = transform;
                enemy.transform.position = new Vector3(Random.Range(-4f, 4f), Random.Range(0f, 10f), Random.Range(-4f, 4f));
                enemy.AddComponent<Rigidbody>();
            }

        } 
    } 
    enum DifficultyModes
    {
        Easy = 1,
        Normal = 3,
        Hard = 10,
        Nightmare = 50
    }
}


