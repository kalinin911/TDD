using System;
using Editor;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace Tests
{
    public partial class HealthBarTests
    {
        private Image _image;
        private HealthElement _healthElement;
            
        [SetUp]
        public void BeforeEveryTest()
        {
            _image = new GameObject().AddComponent<Image>();
            _healthElement = new HealthElement(_image);
        }
        
        public class ReplenishMethod : HealthBarTests
        {
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
            
            [Test]
            public void _Throws_Exception_For_Negative_Number_Of_Health_Pieces()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => _healthElement.Replenish(-1));
            }
        }
        
        public class DepleteMethod : HealthBarTests
        {
            [Test]
            public void _0_Sets_Image_With_100_Percent_Fill_To_100_Percent_Fill()
            {
                _image.fillAmount = 1;
                _healthElement.Deplete(0);
                
                Assert.AreEqual(1, _image.fillAmount);
            }
            
            [Test]
            public void _1_Sets_Image_With_100_Percent_Fill_To_75_Percent_Fill()
            {
                _image.fillAmount = 1;
                _healthElement.Deplete(1);
                
                Assert.AreEqual(0.75f, _image.fillAmount);
            }
            
            [Test]
            public void _2_Sets_Image_With_75_Percent_Fill_To_25_Percent_Fill()
            {
                _image.fillAmount = 0.75f;
                _healthElement.Deplete(2);
                
                Assert.AreEqual(0.25f, _image.fillAmount);
            }

            [Test]
            public void _Throws_Exception_For_Negative_Number_Of_Health_Pieces()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => _healthElement.Deplete(-1));
            }
        }
    }
}
