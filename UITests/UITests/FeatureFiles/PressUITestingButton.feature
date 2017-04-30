Feature: PressUITestingButton
	In order to navigate to HomePage 
	As a tester
	I want to get navigated to Home page	

@High @FormPage @HomePage @Navigation @MouseClick @REQ_UI_08
Scenario Outline: Clicking ErrorButton loads ErrorPage
	Given I have <Page> page opened
	When I press UI Testing button
	Then HomePage should be loaded
	
	Examples: 
	| Page |
	| Home |
	| Form |