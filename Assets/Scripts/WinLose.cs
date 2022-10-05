using UnityEngine;

public class WinLose : MonoBehaviour
{
    public Controls Controls;
    public Canvas LoseScreen;
    public Canvas WinScreen;

    public enum State
    {
        Playing,
        Win,
        Lose,
    }
    public State CurrentState { get; private set; }

    public void OnPlayerDead()
    {
        if (CurrentState == State.Playing)
        {

            CurrentState = State.Lose;
            Controls.enabled = false;
            LoseScreen.gameObject.SetActive(true);
        }
    }

    public void OnPlayerWin()
    {
        if (CurrentState == State.Playing)
        {
            LevelIndex++;
            CurrentState = State.Win;
            Controls.enabled = false;
            WinScreen.gameObject.SetActive(true);
        }
    }

    public int LevelIndex
    {
        get => PlayerPrefs.GetInt("LevelIndex", 1);
        private set
        {
            PlayerPrefs.SetInt("LevelIndex",value);
            PlayerPrefs.Save();
        }
    }
}
