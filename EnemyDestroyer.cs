﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //  gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other){
      if(other.tag=="OpenEnemy"){
        Destroy(other.gameObject);
        gameObject.SetActive(false);
      }
    }
}
