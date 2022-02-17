Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@reportPreparation
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

	
	
	
	
	
	
	
	
	
	
	
	
	
	
		
@smoke
Scenario: Simple add two numbers
	Given the first number is 50
	And the second number is 70
	And open browser window
	#And open browser
	#And 
	When the two numbers are added
	Then the result should be 120
	
@outline	
Scenario Outline: Multiple add two numbers
	Given the first number is <first>
	And the second number is <second>
	When the two numbers are added
	Then the result should be <result>
	And the result should <result> with status <status>
	
	Examples:
	  | first | second | result | status |
	  | 12    | 5      | 17     | true   |
	  | 20    | 5      | 15     | false  |