Feature: OrderPage

Background:
	Given I navigate into the order page

@Regression
Scenario: Order Food
	Given I enter personal details as 'Joseph' and 'Har'
	And I select starters are 'Spring Rolls' and 'Ceasar Salad'
	And I select Main menu items are 'Grilled Salmon' , 'Chicken Tikka' and 'Pasta'
	When I click Checkout Option
	Then I should see the total amount as '29.8'