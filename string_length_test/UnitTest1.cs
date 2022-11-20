using Microsoft.VisualStudio.TestPlatform.TestHost;
using Assignment_2;
using Xunit;

namespace string_length_test
{
    public class UnitTest1
    {
        Assignment_2.Program program = new Assignment_2.Program();
        [Fact]
        public void lengthTest()
        {
            Assert.Equal(0, program.findLength(""));
        }

        [Fact]
        public void FaillengthTest()
        {
            Assert.NotEqual(2, program.findLength("123"));
        }
        [Fact]
        public void lengthTest1()
        {
            Assert.Equal(3, program.findLength("123"));
        }
        [Fact]
        public void lengthTest2()
        {
            Assert.Equal(12, program.findLength("123456789010"));
        }
        [Fact]
        public void lengthTest3()
        {
            string? NULL = null;
            var exception = Record.Exception(() => program.findLength(NULL));
            Assert.IsType<System.NullReferenceException>(exception);
            


        }
    }
}