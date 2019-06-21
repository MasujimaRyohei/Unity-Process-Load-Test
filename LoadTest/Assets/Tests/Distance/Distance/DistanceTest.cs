using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DistanceTest
{
    public class DistanceTest : MonoBehaviour
    {
        void Start()
        {
            Vector2 a = new Vector2(Random.Range(-100, 100), Random.Range(-100, 100));
            Vector2 b = new Vector2(Random.Range(-100, 100), Random.Range(-100, 100));
            
            float temporary;
            
            ProcessChecker.Check(
                "Distance", () => temporary = Vector2.Distance(a, b),
                "sqrMagnitude", () => temporary = (a - b).sqrMagnitude);

        }
    }
}