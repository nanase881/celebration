using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    [SerializeField] float countDownTime = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countDownTime -= Time.deltaTime;

        if (countDownTime > 0 && countDownTime < 10)
        {
            Debug.Log("Ten seconds left!");
        }
        if(countDownTime <= 0)
        {
            Debug.Log("Finish!");
            
        }

    }
}
