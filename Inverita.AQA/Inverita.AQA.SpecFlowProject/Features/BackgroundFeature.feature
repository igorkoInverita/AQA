Feature: BackgroundFeature
	Simple calculator for adding two numbers

Background:
	Given first number already entered	
	
@mytag
Scenario: Add two numbers with background setup
	Given the second number is 70
	When the two numbers are added
	Then the result should be 770