using TMPro;
using UnityEngine;

namespace Project.Scripts.UI
{
    public class FormattedScoreCounter : MonoBehaviour
    {
        [SerializeField] private TMP_Text label;

        private int _currentScore;

        public void AddPoint()
        {
            _currentScore++;
            label.text = _currentScore.ToString("D3");
        }
    }
}