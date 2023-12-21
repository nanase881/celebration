using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CountDown : MonoBehaviour
{
    [SerializeField] float countDownTime = 30f;
    [SerializeField] TextMeshProUGUI countDownText;

    // Update is called once per frame
    void Update()
    {
        countDownTime -= Time.deltaTime;
        countDownText.text = countDownTime.ToString("f1");

        if (countDownTime > 0 && countDownTime < 10)
        {
            Debug.Log("Ten seconds left!");
        }
        if(countDownTime <= 0)
        {
            //Debug.Log("Finish!");
            SceneManager.LoadScene("Result");
        }

    }
}
