using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class HealthBarTests
    {
        public class ReplenishMethod
        {
            private Image _image;
            private HealthElement _healthElement;
            
            [SetUp]
            public void BeforeEveryTest()
            {
                _image = new GameObject().AddComponent<Image>();
                _healthElement = new HealthElement(_image);
            }
            
            [Test]
            public void _0_Sets_Image_With_0_Fill_To_0()
            {
                _image.fillAmount = 0;
            
                _healthElement.Replenish(0);
            
                Assert.AreEqual(0, _image.fillAmount);
            }
            
            [Test]
            public void _1_Sets_Image_With_0_Fill_To_25_Percent_Fill()
            {
                _image.fillAmount = 0;

                _healthElement.Replenish(1);
            
                Assert.AreEqual(0.25f, _image.fillAmount);
            }
            
            [Test]
            public void _1_Sets_Image_With_25_Fill_To_50_Percent_Fill()
            {
                _image.fillAmount = 0.25f;

                _healthElement.Replenish(1);
            
                Assert.AreEqual(0.5f, _image.fillAmount);
            }
        }
        
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
                _image.fillAmount += numberOfPiecesToRestore * FillPiece;
            }
        }
    }
}
