using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    [SerializeField] GameObject tux;
    [SerializeField] GameObject[] possiblePositions = new GameObject[4];

    public void ChangePosition()
    {
        tux.transform.position = possiblePositions[Random.Range(0, possiblePositions.Length)].transform.position;
    }
}
