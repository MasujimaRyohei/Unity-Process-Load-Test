using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GetComponentTest
{
    public class GetComponentTest : MonoBehaviour
    {
        [SerializeField]
        private Data data;

        private void Start()
        {
            string temporary;
            ProcessChecker.Check(
                "GetComponent", () => temporary = GetComponent<Data>().sentence,
                "SerializeField", () => temporary = data.sentence);
        }
    }
}