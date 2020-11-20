Feature: Contact form
@Contact form
Scenario: User can't complete contact form with invalid email
	Given I have navigated to contact page
	And I added Angela value in name field
	And I added angela value in email field
	When I clicked on SEND button
	Then An error message should be shown
@Contact form
Scenario: User can send a message from contact form
	Given I have navigated to contact page
	And I added Angela value in name field
	And I added angela@gmail.com value in email field
	And I added Subject value in subject field
	And I added Message value in message field
	When I clicked on SEND button
	Then I should see a confirmation pop-up
