using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    public static PuzzleManager Instance;
    private int placedCount = 0;
    public GameObject winUI;

    void Awake()
    {
        Instance = this;
        if (winUI) winUI.SetActive(false);
    }

    public void CubePlaced()
    {
        placedCount++;
        if (placedCount >= 3)
        {
            if (winUI) winUI.SetActive(true);
            Debug.Log("🎉 Puzzle Completed!");
        }
    }

    public void RestartPuzzle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
