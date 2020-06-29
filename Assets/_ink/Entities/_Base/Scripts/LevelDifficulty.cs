using UnityEngine;

[CreateAssetMenu(fileName = "Difficulty", menuName = "Configuration/Difficulty", order = 1)]
public class LevelDifficulty : ScriptableObject
{
    public int difficultyIndex;

    public float totalScore;
    public float totalTimer;

    public float minSpawnTime, maxSpawnTime;
    public float minPawnSpeed, maxPawnSpeed;
}
