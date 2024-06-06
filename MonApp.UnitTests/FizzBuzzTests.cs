using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApp.UnitTests
{
    public class FizzBuzzTests
    {
        FizzBuzz fb;

        public FizzBuzzTests()
        {
            fb = new FizzBuzz();
        }

        [Fact]
        public void Au_premier_tout_entrer_1_est_correct()
        {
            // Act
            var result = fb.IsValidInput("1");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Au_premier_tout_entrer_autre_chose_que_1_est_incorrect()
        {
            // Act
            var result = fb.IsValidInput("2");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Au_tour_2_entrer_2_est_correct()
        {
            fb = new FizzBuzz(2);
            // Act
            var result = fb.IsValidInput("2");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Au_tour_3_entrer_Fizz_est_correct()
        {
            fb = new FizzBuzz(3);
            // Act
            var result = fb.IsValidInput("Fizz");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Au_tour_3_entrer_3_est_incorrect()
        {
            fb = new FizzBuzz(3);
            // Act
            var result = fb.IsValidInput("3");

            // Assert
            Assert.False(result);
        }
    }
}
