using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] PlatformsPrefabs;
    public GameObject StartPlatform;
    public int MinPlatforms;
    public int MaxPlatforms;
    public float DistanceBetweenPlatforms;
    public Transform FinishPlatform;

    private void Awake()
    {
        int PlatformsCount = Random.Range(MinPlatforms, MaxPlatforms + 1);

        for (int i = 0; i < PlatformsCount; i++)
        {
            int PrefabIndex = Random.Range(0, PlatformsPrefabs.Length);
            GameObject PlatformPrefab = i == 0 ? StartPlatform : PlatformsPrefabs[PrefabIndex];
            GameObject platform = Instantiate(PlatformPrefab, transform);
            platform.transform.localPosition = CalcPlatformPos(i);
            platform.transform.localRotation = i == 0 ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, Random.Range(0, 360f), 0);
        }

        FinishPlatform.localPosition = CalcPlatformPos(PlatformsCount);
    }

    private Vector3 CalcPlatformPos(int PlatformIndex)
    {
        return new Vector3(0, -DistanceBetweenPlatforms * PlatformIndex, 0);
    }
}
