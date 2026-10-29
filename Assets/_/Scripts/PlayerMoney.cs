using UnityEngine;
using TMPro;
using ColliderEventSystem;

public class MoneyDisplay : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI moneyText;

    [Header("CES Variable")]
    public IntVariable argentTotalVariable;

    [Header("Objectif")]
    public int maxMoney = 1000;

    void Update()
    {
        UpdateMoneyUI();
    }

    void UpdateMoneyUI()
    {
        if (moneyText != null && argentTotalVariable != null)
        {
            int currentMoney = argentTotalVariable.RuntimeValue;

            moneyText.text = currentMoney + "$ / " + maxMoney + "$";
        }
    }
}