using UnityEngine;
using UnityEngine.UI;

public class enemyChanger : MonoBehaviour
{
    public InputField inputField;
    public enemy[] enemies; 

    public void FilterByHealth()
    {
        if (!int.TryParse(inputField.text, out int minHp)) return;
        foreach (var e in enemies) e.gameObject.SetActive(e.health > minHp);
    }

    public void FilterByLevel()
    {
        if (!int.TryParse(inputField.text, out int targetLevel)) return;
        foreach (var e in enemies) e.gameObject.SetActive(e.level == targetLevel);
    }

    public void ResetAll()
    {
        foreach (var e in enemies) e.ResetEnemy();
    }

    public void UpgradeToBoss()
    {
        foreach (var e in enemies)
            if (e.unitName == inputField.text) e.MakeBoss();
    }
}