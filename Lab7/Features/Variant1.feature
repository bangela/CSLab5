Feature: Variant1
@Homepage
Scenario: Check page 
	Given I have navigated to https://www.google.com website
	Then The google page is shown

@Results
Scenario: Check how many results are on page
	Given I have navigated to https://www.google.com website
	When I fill the search input with test
	And I press the search button
	Then Count results on page

@Nothing
Scenario: Search nothing
	Given I have navigated to https://www.google.com website
	When I leave the search input empty
	And I press the search button
	Then The google page is shown

@SearchIrrelevant
Scenario: Irrelevant search
	Given I have navigated to https://www.google.com website
	When I fill the search input with calculato
	And I press the search button
	Then Do you mean link is present