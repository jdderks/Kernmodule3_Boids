using UnityEngine;

public class FlockSpawner : MonoBehaviour
{
    public GameObject boidPrefab;

    [Range(0, 300)]
    public int number;

    private void Start()
    {
        for (int i = 0; i < number; i++)
        {
            Vector3 randomPositionOnScreen = new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), 0);
            Instantiate(boidPrefab, Camera.main.ScreenToWorldPoint(randomPositionOnScreen), Quaternion.identity);
        }
    }
}