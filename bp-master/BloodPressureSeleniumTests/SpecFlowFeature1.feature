Feature: SpecFlowFeature1
	BDD Tests for Blood Pressure Calculator

@mytag
Scenario: Testing Low Blood Pressure
	Given the Systolic number is "89"
	And the Diastolic number is "59"
	
	Then the result should be "Low"