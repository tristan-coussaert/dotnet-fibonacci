using Xunit;

namespace Fibonacci.Tests;

public class UnitTest1
{
    [Fact]        
    public async Task Execute44ShouldRetrun701408733()       
    {            
        var result = await Compute.ExecuteAsync(new[] {"6"});          
        Assert.Equal(701408733, result[0]);  
    }
    
    
}