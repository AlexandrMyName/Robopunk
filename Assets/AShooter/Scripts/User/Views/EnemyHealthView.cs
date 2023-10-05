using UnityEngine;
using Abstracts;
using UnityEngine.UI;


namespace User.View
{

    public class EnemyHealthView : MonoBehaviour, IEnemyHealthView
    {

        [SerializeField] private Slider _healthSlider;
        [SerializeField] private Image _fillImage;

        public void Deactivate() => gameObject.SetActive(false);


        public void RefreshHealth(float currentHealth, float maxHealth)
        {

            if(_healthSlider.maxValue != maxHealth)
            {
                _healthSlider.maxValue = maxHealth;
            }
            _healthSlider.value = currentHealth;

            Color color = Color.Lerp(Color.red, Color.green, currentHealth/maxHealth);
            _fillImage.color = color;

        }


        public void Show() => gameObject.SetActive(true);
        
        public void Show()
        {
            gameObject.SetActive(true);
        }


        public void Hide()
        {
            gameObject.SetActive(false);
        }


        public bool GetActivityState()
        {
            return gameObject.activeSelf;
        }


    }
}