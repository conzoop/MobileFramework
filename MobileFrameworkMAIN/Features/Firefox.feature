Feature: Firefox


Background: 
	Given I am on "https://www.amazon.com/"

@App:Firefox
Scenario: Navigate to Amazon Homepage
	Then I validate I am on the homepage

@App:Firefox
Scenario: I navigate to the Amazon Basics page
	When I go to Amazon Basics
	Then I validate I am on the Amazon Basics Page
	
@App:Firefox
Scenario: I search for and click into the zelda
	When I search for The Legend of Zelda Tears of the Kingdom
	And I click The Legend of Zelda Tears of the Kingdom
	Then I validate I am on the Zelda Tears of the Kingdom Product Page
		
@App:Firefox
Scenario: I add an item to my cart
	When I search for The Legend of Zelda Tears of the Kingdom
	And I click The Legend of Zelda Tears of the Kingdom
	And I add the product to my cart
	Then I validate the item has been added to my basket

@App:Firefox
Scenario: I remove an item to my cart
	When I search for The Legend of Zelda Tears of the Kingdom
	And I click The Legend of Zelda Tears of the Kingdom
	And I add the product to my cart
	And I go to my cart
	And I remove an item from my cart
	Then I validate the item has been removed from my basket

@App:Firefox
	Scenario:I click on a non-existing page
	Then I go to Amazon Books
	

	













