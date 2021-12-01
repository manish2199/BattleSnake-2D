using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassGainer : Food
{
  
 void Start()
 {
    Type = Characters.Food;
    randomisePosition();
 }
 
 void OnTriggerEnter2D ( Collider2D target)
 {
     if(target.GetComponentInChildren<SnakeHead>().charType ==Characters.Snake)
     {
       randomisePosition();
     }
 }

}
