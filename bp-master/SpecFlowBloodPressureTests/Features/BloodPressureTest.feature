Feature: BloodPressureTest

@mytag
Scenario: Testing Low Blood Pressure
	Given the Systolic number is "89"
	And the Diastolic number is "59"
	Then the result should be "Low"

Scenario: Testing Ideal Blood Pressure
	Given the Systolic number is "110"
	And the Diastolic number is "79"
	Then the result should be "Ideal"