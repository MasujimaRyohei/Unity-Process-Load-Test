using UnityEngine;
namespace PositionTest
{
    public class PositionTest : MonoBehaviour
    {
        [SerializeField]
        private Transform obj;

        private void Start()
        {
            ProcessChecker.Check(
                "Position", () => obj.transform.position = new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)),
                "LocalPosition", () => obj.transform.localPosition = new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)));
        }
    }
}