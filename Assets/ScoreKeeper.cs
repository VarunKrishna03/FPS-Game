using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int score = 0;
    public void Scorer(int value)
    {
        score = score + value;
        print("Score " + score);
    }
}
