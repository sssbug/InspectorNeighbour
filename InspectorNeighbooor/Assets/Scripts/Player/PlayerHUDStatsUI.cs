using Hel.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Hel.Player
{
    /// <summary>
    /// Used to display the player's stats to the HUD.
    /// </summary>
    public class PlayerHUDStatsUI : MonoBehaviour
    {
         [SerializeField] private PlayerStatsDataHolder playerStatsDataHolder = null;
         [SerializeField] private Slider healthbarSlider = null;
         [SerializeField] private TextMeshProUGUI healthbarSliderText = null;
         [SerializeField] private Slider manabarSlider = null;
         [SerializeField] private TextMeshProUGUI manabarSliderText = null;
         [SerializeField] private Image experienceImage = null;
         [SerializeField] private TextMeshProUGUI playerLevelText = null;

        private void Start()
        {
            UpdateHealthUI();
            UpdateManaUI();
            UpdateExperience();
        }

        public void UpdateHealthUI()
        {
            int currentHealth = playerStatsDataHolder.StatsHolder.Health;
            int maxHealth = playerStatsDataHolder.StatsHolder.GetStatValue(StatTypes.MaxHealth);
            healthbarSlider.value = (float)currentHealth / maxHealth;
            healthbarSliderText.text = $"{currentHealth}/{maxHealth}";
        }

        public void UpdateManaUI()
        {
            int currentMana = (int)playerStatsDataHolder.Mana;
            int maxMana = playerStatsDataHolder.StatsHolder.GetStatValue(StatTypes.MaxMana);
            manabarSlider.value = (float)currentMana / maxMana;
            manabarSliderText.text = $"{currentMana}/{maxMana}";
        }

        public void UpdateExperience()
        {
            playerLevelText.text = playerStatsDataHolder.LevelSystem.Level.ToString();
            experienceImage.fillAmount = (float)playerStatsDataHolder.LevelSystem.CurrentExperience / playerStatsDataHolder.LevelSystem.ExperienceForLevelUp;
        }
    }
}
