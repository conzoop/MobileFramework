Feature: Calculator

	@App:Calculator
Scenario: Power
	Given I click on the number Nine
	When I click to the power of
	And I click the number Two
	Then I validate the answer is 81

	@App:Calculator
Scenario: Addition
	Given I click the number Eight
	When I click add
	And I click the number Two
	Then I validate the answer is 10

	@App:Calculator
Scenario: Subtraction
	Given I click the number Eight
	When I click Subtract
	And I click the number Two
	Then I validate the answer is 6

	@App:Calculator
Scenario: Multiplication
	Given I click the number Eight
	When I click Multiply
	And I click the number Four
	Then I validate the answer is 32

	@App:Calculator
Scenario: Division
	Given I click the number Eight
	When I click Divide
	And I click the number Two
	Then I validate the answer is 4

	@App:Calculator
Scenario: DivisionNegative
	Given I click the number Eight
	When I click Divide
	And I click the number Two
	Then I validate the answer is 6