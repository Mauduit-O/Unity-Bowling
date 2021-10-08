using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int point=0;

    public void addpoints()
    {
        point++;
        GetComponent<Text>().text = "score :"+point+"";
    }
}
