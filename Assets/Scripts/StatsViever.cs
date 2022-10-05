using Assets.Scripts;
using TMPro;
using UnityEngine;

public class StatsViever : MonoBehaviour
{
    public WinLose WinLose;
    public TextMeshProUGUI ThisLevel;
    public TextMeshProUGUI NextLevel;
    void Update()
    {
        ThisLevel.text = WinLose.LevelIndex.ToString();
        int nLevel = WinLose.LevelIndex + 1;
        NextLevel.text = nLevel.ToString();
    }
}
