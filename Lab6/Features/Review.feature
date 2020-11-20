Feature: Review
@Review
Scenario: User is able to leave a review
	Given I have navigated to product page
	And I opened Reviews tab
	And I completed first field with Angela value
	And I completed email field with angela.beregoi@gmail.com value
	And I added Review text in box for comments
	When I clicked on SEND button
	Then The review should contains Review message