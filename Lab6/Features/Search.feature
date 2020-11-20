Feature: Search
@Search
Scenario: Perform search with valid data
	Given I have navigated to website
	And I have entered Product as a search keyword
	When I press the search button
	Then I should navigate to search result page