using System;
using Xunit;
using XUnitIntroPractice;

namespace XUnitIntroPractice_Tests
{
    public class UnitTest1
    {
        [Fact]
        public static void Test1()
        {

            Program.HelloWorld();
        }
        //Write XUnit tests that will test the trimming of whitespace (both spaces and tabs) before and after the text.
        //9 test case permutations.

        [Theory,
         InlineData("Yes", true),
         InlineData("Y", true),
         InlineData("NO", true),
         InlineData(" N", true),
         InlineData(" Yes", true),
         InlineData(" Y", true),
         InlineData(" NO ", true),
         InlineData(" N   ", true),
         InlineData("    N ", true)]



        public void Contains_Test(string myString1, bool result)
        {
         
            Assert.True(result, myString1);

        }

        //Write XUnit tests that will test the conversion to uppercase.
        //3 test case permutations.

        [Theory,
             InlineData("yes",true),
             InlineData("y", true),
             InlineData("no", true)]

        public void Str_ToUpper(string newStr, bool upperStr)
        {
            Assert.True(upperStr, newStr);
        }

        //Write XUnit tests for all accepted values.
        //4 test case permutations.

        [Theory,
             InlineData("hi", true),
             InlineData("HELLO1", true),
            InlineData("MaRK", true),
             InlineData("John", true)
             ]

        public void AcceptValue(string newStr1, bool anyStr)
        {
            Assert.True(anyStr, newStr1);
        }

        //Write XUnit tests for invalid values. Include at least one single character invalid value, one multiple character one, and an empty string.

        [Theory,
             InlineData("c", false),
             InlineData("", false),
            InlineData("no", false),
            
             ]

        public void InvalidValue(string newStr2, bool invalidStr)
        {
            Assert.False(invalidStr, newStr2);
        }


        [Theory,
       InlineData("yes")
       ]
        public void IntParse_Test_Invalid(string test)
        {
            // Throws will require that a specific exception type is thrown, not any derived type, or any other type.
            Assert.Throws<FormatException>(() => int.Parse(test));
           
        }

        //Write assertions using Throws<FormatException>, Throws<IndexOutOfRangeException>, Throws<NullReferenceException> and Throws<DivideByZero Exception>,
        [Theory,
        InlineData(10, 0),
        InlineData(5, 0)]
        public void Divide(int one, int two)
        {
            Assert.Throws<DivideByZeroException>(() => Program.Divide(one, two));
        }

        [Theory,
        InlineData()]
        public void NullExec()
        {
            Assert.Throws<NullReferenceException>(() => Program.NullExec());
        }

        [Theory,       
        InlineData(5, 10)]
        public void PopulateArray(int x, int y)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Program.PopulateArray(x,y));
        }
    }
}
