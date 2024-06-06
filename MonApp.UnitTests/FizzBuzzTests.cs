using NFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApp.UnitTests
{
    public class FizzBuzzTests : IDisposable
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

        [Theory]
        [InlineData([3, "Fizz", true])]
        [InlineData([3, "3", false])]
        [InlineData([4, "Fizz", false])]
        [InlineData([3, "Buzz", false])]
        [InlineData([6, "Fizz", true])]
        [InlineData([9, "Fizz", true])]
        public void Si_le_tour_est_multiple_de_3_entrer_fizz_est_correct_et_entrer_autre_chose_est_incorrect(int tour, string input, bool expected)
        {
            fb = new FizzBuzz(tour);
            // Act
            var result = fb.IsValidInput(input);

            // Assert
            Assert.Equal(expected, result);
        }
        [Theory]
        [MemberData(nameof(GenerateFizzTestData))]
        public void Demo_memeberdata_si_le_tour_est_multiple_de_3_entrer_fizz_est_correct_et_entrer_autre_chose_est_incorrect(int tour, string input, bool expected)
        {
            fb = new FizzBuzz(tour);
            // Act
            var result = fb.IsValidInput(input);

            // Assert
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GenerateFizzTestData()
        {
            yield return [3, "Fizz", true];
            yield return [6, "Fizz", true];
            yield return [6, "4", false];
        }

        public void Dispose()
        {
            // Nettoyage
        }
    }
}
