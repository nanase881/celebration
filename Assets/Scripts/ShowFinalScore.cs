using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowFinalScore : MonoBehaviour
{
    int Score1, Score2, Score4;
    [SerializeField] TextMeshProUGUI ScoreText1;
    [SerializeField] TextMeshProUGUI ScoreText2;
    [SerializeField] TextMeshProUGUI ScoreText4;
    // Start is called before the first frame update
    void Start()
    {
        Score1 = Items.ReturnCount1();
        Score2 = Items.ReturnCount2();
        Score4 = Items.ReturnCount4();

        ScoreText1.text = Score1.ToString();
        ScoreText2.text = Score2.ToString();
        ScoreText4.text = Score4.ToString();
    }

  
}
