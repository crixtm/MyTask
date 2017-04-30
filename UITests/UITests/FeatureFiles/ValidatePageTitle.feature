Feature: ValidatePageTitle
	In order to check correct branding
	As a tester
	I want to validate the pages title

@Moderate @Title @AllPage @REQ_UI_01
Scenario Outline: Validate that the title of the page
	Given I have opened the browser
	When I open <Page>
	Then the title is valid
	
	Examples: 
	| Page  |
	| Home  |
	| Form  |
	
	
