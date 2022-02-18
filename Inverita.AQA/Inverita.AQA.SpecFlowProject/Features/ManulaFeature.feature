#@manualOnly
Feature: ManulaFeature
	Simple calculator for adding two numbers

@asGuestUser
Scenario: Add two numbers1
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
	
@smoke
Scenario: Add two numbers2
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120