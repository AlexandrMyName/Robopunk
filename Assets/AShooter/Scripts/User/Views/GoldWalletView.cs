using Abstracts;
using TMPro;
using UnityEngine;


namespace User.View
{

    public class GoldWalletView : MonoBehaviour, IGoldWalletView
    {

        [SerializeField] private TMP_Text _textUI;


        public void Show() => gameObject.SetActive(true);


        public void ChangeDisplay(int value)
        {
            _textUI.text = $"Gold: {value}";
        }


    }
}