using UnityEngine;
using UnityEngine.UI;

namespace Editor
{
    public class App : MonoBehaviour
    {
        [SerializeField] private Image image;
        private HealthElement _healthElement;

        void Start()
        {
            _healthElement = new HealthElement(image);
        }

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.DownArrow))
                _healthElement.Deplete(1);
            
            if(Input.GetKeyDown(KeyCode.UpArrow))
                _healthElement.Replenish(1);
        }
    }
}