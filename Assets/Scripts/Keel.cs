using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keel : MonoBehaviour
{
    public int score;

    public Score s;
    private bool hit=false;

    private void OnCollisionEnter(Collision coll)
    {
        if (!hit && coll.gameObject.tag == "Player")
        {
            s.addpoints();
            hit = true;
        }
            
    }
}
