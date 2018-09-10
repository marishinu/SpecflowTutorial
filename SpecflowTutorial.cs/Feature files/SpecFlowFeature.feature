Feature: SpecFlowFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Demo
Scenario: Add two numbers
	Given I have entered 10 into the calculator
	And I have entered 10 into the calculator
	When I press add
	Then the result should be 70 on the screen


@SmokeTest
Scenario: Create Order request Demo
	Given Connect to http://wddceqcaapi01:18929
	And API url is /orders
	And The API method is POST
	And Request params are added
	When The request is executed 
	Then the Status code should be OK

@SmokeTest
Scenario: GetOrder Order request Demo
	Given Connect to http://wddceqcaapi01:18929
	And API url is /orders/{orderid}
	And The API method is GET
	And Request params are added
	When The request is executed 
	Then the Status code should be OK
	



