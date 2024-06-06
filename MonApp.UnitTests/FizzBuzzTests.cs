using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApp.UnitTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Au_premier_tout_entrer_1_est_correct()
        {
            // Arrange

            // Act
            var result = FizzBuzz.IsValidInput(1, "1");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Au_premier_tout_entrer_autre_chose_que_1_est_incorrect()
        {
            // Arrange

            // Act
            var result = FizzBuzz.IsValidInput(1, "2");

            // Assert
            Assert.True(result);
        }
    }
}
