using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public List<Collider2D> targetList = new List<Collider2D>();

    private void OnTriggerEnter2D(Collider2D other)
    {
        targetList.Add(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        targetList.Remove(other);
    }
}
