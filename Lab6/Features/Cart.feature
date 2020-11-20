Feature: Cart
@Cart
Scenario: Items are added to cart
	Given I have navigated to women cloths
	When I added 2 products to cart
	Then I should have 2 products in cart