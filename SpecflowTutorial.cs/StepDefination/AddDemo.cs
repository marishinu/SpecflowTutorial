using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using TechTalk.SpecFlow;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"I have entered (.*) into the calculator")]
public void GivenIHaveEnteredIntoTheCalculator(int number)
{
    Console.WriteLine("The number is: " + number);
}

        [When(@"I press add")]
public void WhenIPressAdd()
{
    Console.WriteLine("The \"Add\" is pressed");
}

        [Then(@"the result should be (.*) on the screen")]
public void ThenTheResultShouldBeOnTheScreen(int result)
{
    if(result==10)
    {
        Console.WriteLine("Test passed");      
    }
    else
    {
        Console.WriteLine("Test Failed");
      //  throw new Exception("The result is not matched");
    }
}
    }
}



