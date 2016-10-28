Feature: CalcSpecExcel
Add two numbers with values 
from excel sheet

@SmokeTest

Scenario Outline: Add two Numbers
Given I have entered <x> into the calculator
Given Also have entered <y> into the calculator
When I press add
Then the result of adding <x> and <y> should be <result> on the screen

@Source:CaclulatorValues.xlsx
Scenarios: addition
| x | y | result|

9686067274