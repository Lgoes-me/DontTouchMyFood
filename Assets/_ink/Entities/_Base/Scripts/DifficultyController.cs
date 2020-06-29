using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class DifficultyController : MonoBehaviour
{

    public LevelDifficulty[] levelPresetDifficulty;
    public int difficultyIndex = 0;
    public LevelDifficulty currentDifficulty;

    public FloatVariable totalScore;
    public FloatVariable totalTimer;

    public FloatVariable minSpawnTime, maxSpawnTime;
    public FloatVariable minPawnSpeed, maxPawnSpeed;
        
    public void ChangeToRandomDifficulty()
    {
        int newIndex = Random.Range(0, levelPresetDifficulty.Length);

        if (difficultyIndex == newIndex)
        {
            ChangeToRandomDifficulty();
            return;
        }
        difficultyIndex = newIndex;

        ChangeDifficulty();
    }
    
    public void ChangeDifficulty()
    {
        difficultyIndex = Mathf.Clamp(difficultyIndex, 0, levelPresetDifficulty.Length);

        currentDifficulty = levelPresetDifficulty[difficultyIndex];

        totalScore.Value = currentDifficulty.totalScore;
        totalTimer.Value = currentDifficulty.totalTimer;

        minSpawnTime.Value = currentDifficulty.minSpawnTime;
        maxSpawnTime.Value = currentDifficulty.maxSpawnTime;

        minPawnSpeed.Value = currentDifficulty.minPawnSpeed;
        maxPawnSpeed.Value = currentDifficulty.maxPawnSpeed;
    }
}
