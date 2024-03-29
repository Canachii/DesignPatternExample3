using UnityEngine;

public abstract class Upgrade : MonoBehaviour
{
    public abstract int Require { get; set; }
    protected abstract int Level { get; set; }

    protected virtual void Start()
    {
        Level = 1;
    }

    protected virtual bool IsUpgrade()
    {
        if (GameManager.instance.Gold >= Require)
        {
            GameManager.instance.Gold -= Require;
            return true;
        }

        Debug.Log($"Need {Require - GameManager.instance.Gold:N0} Gold to upgrade");
        return false;
    }

    public abstract void LevelUp();
}