using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHead : MonoBehaviour
{
  
  public static event Action<string> snakeHitSomething = delegate { };

  [HideInInspector]public Characters charType;

  // [HideInInspector] int score;
 

  void Awake()
  {
    charType = Characters.Snake;
  }

  void OnTriggerEnter2D(Collider2D target)
  {
    if(target.tag == "Apple")
    {
      snakeHitSomething("Apple");      
    }
    if(target.tag == "RedChilli")
    {
      snakeHitSomething("RedChilli");
    }
    if(target.tag == "Shield")
    {
      snakeHitSomething("shield");
    }
    if(target.tag == "Speed")
    {
      snakeHitSomething("SpeedBooster");
    }
    if( target.tag == "Boundary")
    {
      snakeHitSomething("Boundary");
    }
    if(target.tag == "SnakeBody")
    {
      snakeHitSomething("SnakeBody");
    }
 }
}
