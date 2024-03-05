using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TMP_Text value;
    private int valueInt = 0;

    private void Start()
    {
        value = GameObject.Find("Value").GetComponent<TMP_Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "metal")
        {
            //metal logic
            valueInt += 5;
            value.text = valueInt.ToString();
            print("metal gives 5 Points");
        }
        else
        {
            if (other.gameObject.tag == "wood")
            {
                //wood logic
                valueInt += 1;
                value.text = valueInt.ToString();
                print("wood gives 1 Points");

            }
        }
    }


}
