using UnityEngine;
using UnityEngine.UI;

public class UpgradeSeed : Upgrade
{
    public Text gText;
    public Button button;

    public override int Require { get; set; }

    private const int RequireToUpgradeMax = 10;
    private int _level;

    protected override int Level
    {
        get => _level;
        set
        {
            _level = value;
            Require = (int)Mathf.Pow(RequireToUpgradeMax, _level);
            gText.text = $"{Require:N0}";
        }
    }

    public override void LevelUp()
    {
        if (IsUpgrade())
        {
            Level++;
            Debug.Log($"Max seed(s) now {Level}");
        }
    }
}