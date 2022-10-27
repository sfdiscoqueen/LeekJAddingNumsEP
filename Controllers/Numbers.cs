// Jasmine Leek
// 25oct2022
// Add 2 Numbers - Endpoint
// This is an api that allows a user to add 2 numbers to the endpoint
// peer review: Elizar Garcia, Code works great! shows up on postman without aa problem. i put in two seperate numbers into two seperate urls and got the correct total. great job!


using Microsoft.AspNetCore.Mvc;

namespace LeekJAddingNumsEP.Controllers;

[ApiController]
[Route("[controller]")]
public class NumbersController : ControllerBase
{
    [HttpGet]
    [Route("Adding/{number1}/{number2}")]

    public int Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        return convertNum1 + convertNum2;
    }

}
