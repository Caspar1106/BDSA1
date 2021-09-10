using Xunit;

namespace Assignment1.Tests
{
    public class Given_stream_of_T_return_Stream_T
    {
            //arrange
            // IEnumerable<t> input = new IEnumerable<t>; 
            var input = new [][] {
                [0] {1,2,3,4,5}
                [1] {5,4,3,2,1}
            };

            //act
            var output = Flatten(input.getEnumerator());

            //assert
            Assert.Equals(input.getEnumerator(), output);

    }
}
