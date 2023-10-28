using System;
using UnityEngine.UI;

namespace Editor
{
    public class HealthElement
    {
        private readonly Image _image;
        private const float FillPiece = 0.25f;
                
        public HealthElement(Image image)
        {
            _image = image;
        }

        public void Replenish(int numberOfPiecesToRestore)
        {
            if (numberOfPiecesToRestore < 0) throw new ArgumentOutOfRangeException("numberOfPiecesToRestore");

            _image.fillAmount += numberOfPiecesToRestore * FillPiece;
        }

        public void Deplete(int numberOfPiecesToRestore)
        {
            if (numberOfPiecesToRestore < 0) throw new ArgumentOutOfRangeException("numberOfPiecesToRestore");
                
            _image.fillAmount -= numberOfPiecesToRestore * FillPiece;
        }
    }
}