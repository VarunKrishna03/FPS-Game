using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public int  myscorevalue;
    private void OnCollisionEnter(Collision collision)
    {
        ScoreKeeper scorekeeper = FindObjectOfType<ScoreKeeper>();
        scorekeeper.Scorer(myscorevalue);

    }
}
