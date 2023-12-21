using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    int Score1, Score2, Score4;
    //[SerializeField] Text ScoreText1;
    //[SerializeField] Text ScoreText2;
    //[SerializeField] Text ScoreText4;
    [SerializeField] TextMeshProUGUI ScoreText1;
    [SerializeField] TextMeshProUGUI ScoreText2;
    [SerializeField] TextMeshProUGUI ScoreText4;

    
    void Update()
    {
        Score1 = Items.ReturnCount1();
        Score2 = Items.ReturnCount2();
        Score4 = Items.ReturnCount4();

        ScoreText1.text = Score1.ToString();
        ScoreText2.text = Score2.ToString();
        ScoreText4.text = Score4.ToString();
    }

   
}
