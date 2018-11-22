using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int totalscore;

    private void Update()
    {
        scoreText.text = string.Format("Score: {0}", totalscore);
    }
}
