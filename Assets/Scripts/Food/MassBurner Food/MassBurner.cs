using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassBurner : Food
{
 void OnTriggerEnter2D ( Collider2D target)
 {
    if(target.GetComponentInChildren<SnakeHead>().charType ==Characters.Snake)
    {
       randomisePosition();
    }
 }
}
