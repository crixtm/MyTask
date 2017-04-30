Feature: CheckHomePageElementsExist
	In order to check HomePage needed visual elements
	As a tester
	I want to see the elements

@Low @HomePage @VisualElements  @REQ_UI_09 @REQ_UI_10
Scenario Outline: Validate the expected messages
	Given I have opened the browser
	When I open <Page>
	Then welcome message should shown
	And dedication message should shown

	Examples: 
	| Page |
	| Home |