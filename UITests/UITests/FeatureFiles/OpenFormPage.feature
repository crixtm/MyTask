Feature: Opening FormPage
	In order to navigate to form page
	As a tester
	I want to get navigated to FormPage

@High @HomePage @FormPage @Navigation @MouseClick @REQ_UI_05 
Scenario: Clicking FormButton loads FormPage
	Given I have Home page opened
	When I press Form button
	Then FormPage should be loaded

@Low @HomePage @FormPage @Navigation @MouseClick @REQ_UI_06
Scenario: Clicking FormButton activates it 
	Given I have Home page opened
	When I press Form button
	Then Form button should be active


