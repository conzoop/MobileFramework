Feature: Calculator

@mytag @App:Calculator
Scenario: Power
	Given I click on the number Nine
	When I click to the power of
	And I click the number Two
	Then I validate the answer is 81

Scenario: Addition
	Given I click the number Eight
	When I click add
	And I click the number Two
	Then I validate the answer is 10

Scenario: Subtraction
	Given I click the number Eight
	When I click Subtract
	And I click the number Two
	Then I validate the answer is 6

Scenario: Multiplication
	Given I click the number Eight
	When I click Multiply
	And I click the number Four
	Then I validate the answer is 24

Scenario: Division
	Given I click the number Eight
	When I click Divide
	And I click the number Two
	Then I validate the answer is 4