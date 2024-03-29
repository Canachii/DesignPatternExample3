using System;
using UnityEngine;

public class FarmerCollider : MonoBehaviour
{
    public bool IsTouch { get; private set; }
    public bool IsExist { get; set; }
    public string Thing { get; private set; }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            IsTouch = true;
        }

        if (other.CompareTag("Crop"))
        {
            IsExist = true;
        }

        Thing = other.name;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            IsTouch = false;
        }

        if (other.CompareTag("Crop"))
        {
            IsExist = false;
        }

        Thing = "";
    }
}