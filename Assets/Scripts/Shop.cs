using UnityEngine;

public class Shop : MonoBehaviour
{
    private GameObject _panel;
    
    private void Start()
    {
        _panel = GameManager.instance.panel;
        _panel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            _panel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            _panel.SetActive(false);
        }
    }
}