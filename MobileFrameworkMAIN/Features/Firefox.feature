Feature: Firefox

@App:Firefox
Scenario: Testing URL

	Given I am on "https://www.amazon.com/"

@App:Firefox
Scenario: Navigate to Amazon Homepage
	Given I am on "https://www.amazon.co.uk/"
	When I validate I am on the homepage

@App:Firefox
Scenario: I navigate to the Amazon Basics page
	Given I am on "https://www.amazon.co.uk/"
	When I go to Amazon Basics
	Then I validate I am on the Amazon Basics Page
	

@App:Firefox
Scenario: I search for and click into the zelda
	Given I am on "https://www.amazon.co.uk/"
	When I search for The Legend of Zelda Tears of the Kingdom
	And I click The Legend of Zelda Tears of the Kingdom
	Then I validate I am on the Zelda Tears of the Kingdom Product Page

	
@App:Firefox
Scenario: I add an item to my cart
	Given I am on "https://www.amazon.co.uk/"
	When I search for The Legend of Zelda Tears of the Kingdom
	And I click The Legend of Zelda Tears of the Kingdom
	And I add the product to my cart
	Then I validate the item has been added to my basket

@App:Firefox
Scenario: I remove an item to my cart
	Given I am on "https://www.amazon.co.uk/"
	When I search for The Legend of Zelda Tears of the Kingdom
	And I click The Legend of Zelda Tears of the Kingdom
	And I add the product to my cart
	And I go to my cart
	And I remove an item from my cart
	Then I validate the item has been removed from my basket
	

	













