Feature: CheckFormPageElementsExist
	In order to check HomePage needed visual elements
	As a tester
	I want to see the elements

@High @FormPage @FormElements REQ_UI_11
Scenario Outline: Validate the expected messages
	Given I have opened the browser
	When I open <Page>
	Then inputbox should appear
	And submit button should appear

	Examples: 
	| Page |
	| Form |