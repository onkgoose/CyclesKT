using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public string unitName = "shark";
    public int health = 100;
    public int level = 1;

    public Text nameText;
    public Text healthText;
    public Text levelText;

    private string _startName;
    private int _startHealth;
    private int _startLevel;

    void Awake()
    {
        _startName = unitName;
        _startHealth = health;
        _startLevel = level;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (nameText) nameText.text = unitName;
        if (healthText) healthText.text = "HP: " + health;
        if (levelText) levelText.text = "LVL: " + level;
    }

    public void MakeBoss()
    {
        unitName = "boss";
        level += 1;
        health *= 3;
        RefreshUI();
    }

    public void ResetEnemy()
    {
        unitName = _startName;
        health = _startHealth;
        level = _startLevel;
        gameObject.SetActive(true);
        RefreshUI();
    }
}
