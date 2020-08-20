using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace MVPSample.Scripts
{
    public sealed class CountView : MonoBehaviour
    {
        [SerializeField] Text countLabel;
        [SerializeField] Button countUpButton;

        public IObservable<Unit> OnCountUpButtonClickAsObservable() => countUpButton.OnClickAsObservable();

        public void UpdateCountLabel(int count)
        {
            countLabel.text = $"Count: {count}";
        }
    }
}
