Feature: Sign in
@SignIn
Scenario: The user should be able to sign-in
	Given I have navigated to website
	And I click on sign-in button
	And I have entered Name in name field
	And I have entered Password in password field
	When I press the sign-in button
	Then I should be loged in app

@SignIn
Scenario: User can login in app with facebook account
	Given I have navigated to website
	And I click on sign-in button
	When I press the facebook button
	Then I should be redirected to facebook