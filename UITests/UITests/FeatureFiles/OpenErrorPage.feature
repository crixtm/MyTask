Feature: OpenErrorPage
	In order to check error tolerance
	As a tester
	I want to see the error page and the HTTP404 error	

@High @ErrorPage @FormPage @HomePage @Navigation @MouseClick @REQ_UI_07
Scenario Outline: Clicking ErrorButton loads ErrorPage
	Given I have <Page> page opened
	When I press Error button
	Then Http 404 Error should appear
	
	Examples: 
	| Page |
	| Home |
	| Form |