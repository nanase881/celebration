using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    static int count1 = 0;
    static int count2 = 0;
    static int count4 = 0;
    [SerializeField] GameObject playSE;
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Instantiate(playSE, transform.position, transform.rotation);

            Destroy(gameObject);
            
            if (this.gameObject.CompareTag("box1"))
            {
                count1++;
            }
            else if (this.gameObject.CompareTag("box2"))
            {
                count2++;
            }
            else if (this.gameObject.CompareTag("box4"))
            {
                count4++;
            }
            Debug.Log(count1);
            Debug.Log(count2);
            Debug.Log(count4);
        }
    }

    public static int ReturnCount1()
    {
        return count1;
    }

    public static int ReturnCount2()
    {
        return count2;
    }

    public static int ReturnCount4()
    {
        return count4;
    }
}
