using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject buttonPrefab;
    public Text goldText;
    public GameObject panel;

    public UpgradeSeed upgradeSeed;

    private const int MaxGold = 99_999_999;
    private int _gold;

    public int Gold
    {
        get => _gold;
        set
        {
            _gold = Mathf.Clamp(value, 0, MaxGold);
            goldText.text = $"{value:N0}";
        }
    }
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        var temp = Instantiate(buttonPrefab, panel.transform, false);
        var kit = temp.GetComponent<UpgradeSeed>();
        kit.button.onClick.AddListener(kit.LevelUp);
        
        Gold = 0;
    }
}