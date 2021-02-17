Feature: Cart
	Check if cart functionality works

@mytag
Scenario: Add Notebook to Cart
	Given I navigate to Notebooks page
	Given I click on the cart button
	Then I check that notebook was added to the cart