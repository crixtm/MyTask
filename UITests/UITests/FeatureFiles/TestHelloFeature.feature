Feature: TestHelloFeature
	In order to say hello to the user
	As a tester
	I want to hello page with the user's name

@mytag
Scenario Outline: Say Hello to the user
	Given I have Form page opened
	And I have entered <value> to the input
	When I press Go! button
	Then Hello Page should open
	And the greetings <value> should appear

	Examples: 
	| value   | result         |
	| John    | Hello John!    |
	| Sophia  | Hello Sophia!  |
	| Charlie | Hello Charlie! |
	| Emily   | Hello Emily!   |

