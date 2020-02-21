using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private string leyenda = "Score:";
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = leyenda +" "+score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = leyenda + " " + score;
    }

    public void setScore(int v)
    {
        this.score += v;
    }
}
