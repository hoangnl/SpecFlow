﻿# ------------------------------------------------------------------------------
#  <auto-generated>
#      This code was generated by SpecFlow+ Excel (http://www.specflow.org/plus/Excel).
#      SpecFlow Version:2.1.0.0
#      SpecFlow+ Excel Version:1.4.2.0
#
#      SpecFlow+ Excel Evaluation Mode - Please purchase at http://www.specflow.org/plus.
# 
#      Changes to this file may cause incorrect behavior and will be lost if
#      the code is regenerated.
#  </auto-generated>
# ------------------------------------------------------------------------------

Feature: Calculator

Scenario: SpecFlow+ Excel Evaluation Mode
	* Please purchase at http://www.specflow.org/plus to remove this scenario.


Scenario Outline: Sheet1
	Given I have entered <a> into the calculator
	And I have also entered <b> into the calculator
	When I press add
	Then the result should be <result> on the screen

Examples: 
	| case                    | a  | b   | result |
	| Addition                | 30 | 70  | 100    |
	| Substract               | 25 | -10 | 15     |
	| Adding negative numbers | -5 | -1  | -6     |


