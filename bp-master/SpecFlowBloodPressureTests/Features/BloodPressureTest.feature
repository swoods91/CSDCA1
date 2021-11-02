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

Scenario: Testing Ideal Blood Pressure Systolic Range
	Given the Systolic number is "110"
	And the Diastolic number is "59"
	Then the result should be "Ideal"

Scenario: Testing Pre-High Blood Pressure Systolic Way
	Given the Systolic number is "130"
	And the Diastolic number is "70"
	Then the result should be "PreHigh"

Scenario: Testing Pre-High Blood Pressure Diastolic Way
	Given the Systolic number is "120"
	And the Diastolic number is "89"
	Then the result should be "PreHigh"

Scenario: Testing High Blood Pressure Systolic Way
	Given the Systolic number is "140"
	And the Diastolic number is "89"
	Then the result should be "High"

Scenario: Testing High Blood Pressure Diastolic Way
	Given the Systolic number is "130"
	And the Diastolic number is "90"
	Then the result should be "High"

Scenario: Testing Not Valid Systolic Less than Diastolic
	Given the Systolic number is "90"
	And the Diastolic number is "130"
	Then the result should be "NotValid"

Scenario: Testing Not Valid Outside Parameters
	Given the Systolic number is "191"
	And the Diastolic number is "39"
	Then the result should be "NotValid"