using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    int finalScore1, finalScore2, finalScore4;
    [SerializeField] Text finalScoreText1;
    [SerializeField] Text finalScoreText2;
    [SerializeField] Text finalScoreText4;
    // Start is called before the first frame update
    void Start()
    {
        finalScore1 = Items.ReturnCount1();
        finalScore2 = Items.ReturnCount2();
        finalScore4 = Items.ReturnCount4();

        finalScoreText1.text = finalScore1.ToString();
        finalScoreText2.text = finalScore2.ToString();
        finalScoreText4.text = finalScore4.ToString();
    }

   
}
