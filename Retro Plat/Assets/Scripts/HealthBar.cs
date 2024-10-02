using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image TotalHealthBar;
    [SerializeField] private Image currentHealthBar;

    private void Start()
    {
        TotalHealthBar.fillAmount = playerHealth.CurrentHealth / 3;  
    }
    private void Update()
    {
        currentHealthBar.fillAmount = playerHealth.CurrentHealth / 3;
    }
}