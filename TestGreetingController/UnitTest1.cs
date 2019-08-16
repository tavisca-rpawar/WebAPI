using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace TestGreetingController
{
    public class UnitTest1
    {
        SampleWebAPI.Controllers.GreetingController greet = new SampleWebAPI.Controllers.GreetingController();
        [Fact]
        public void Test_Default()
        {
            string expected = "No Input";
            ActionResult<string> actual = greet.Get();
            Assert.Equal(expected, actual.Value);
        }
        [Fact]
        public void Test_Hello_Input()
        {
            string expected = "Hi Rupika";
            ActionResult<string> actual = greet.Get("Hello", "Rupika");
            Assert.Equal(expected, actual.Value);
        }
        [Fact]
        public void Test_Invalid_Input()
        {
            string expected = "Invalid Input";
            ActionResult<string> actual = greet.Get("Good Morning", "Hi");
            Assert.Equal(expected, actual.Value);
        }
    }
}
