Feature: Logo on the page
	In order to check correct branding
	As a tester
	I want to validate the company logo appears on every page

@Moderate @Logo @AllPage @REQ_UI_02
Scenario Outline: Test whether the company logo appeared or not 
	Given I have opened the browser
	When I open <Page>
	Then the logo should appear
	Examples: 
	| Page  |
	| Home  |
	| Form  |
