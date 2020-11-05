Feature: SpecFlowTest
	In order to validate login
	As an admin user
	I want to authenitcate into casqad.org@SmokeTest

Scenario: ValidateLogin
	Given I navigate to authentication page
	When I login with following credentials:
	| userEmail             | userPassword |
	| admin.test3@gmail.com | password123  |
	#When I login with user 'admin.test3@gmail.com'
	#	And password 'password123'
	Then I am loged in

#Scenario Outline: ValidateLogin
#	Given I navigate to authentication page	When I login with user '<userEmailValue>'
#	Then I am loged inExamples:
#| userEmailValue        |
#| admin.test3@gmail.com |
#| test@test.com         |