Feature: Opening home Page
	In order to navigate to home page
	As a tester
	I want to get navigated to Home page

@High @HomePage @FormPage @Navigation @MouseClick @REQ_UI_03 
Scenario: Clicking HomeButton loads HomePage
	Given I have Form page opened
	When I press Home button
	Then HomePage should be loaded

@Low @HomePage @FormPage @Navigation @MouseClick @REQ_UI_04
Scenario: Clicking HomeButton activates it 
	Given I have Form page opened
	When I press Home button
	Then Home button should be active
