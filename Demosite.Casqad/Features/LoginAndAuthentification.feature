Feature: AuthenticateAndLogin
	In order to validate Login
	As an admin user
	I want to authenticate on the Casqad

@AuthenticateAndLogin
Scenario Outline: AuthenticateAndLogin
	Given I navigate to my authentication page
	When I login with following credentials
	| userEmail             |   userPassword		|
	| <userEmailValue>		|   <userPasswordValue> |
	Then I am logged in

Examples: 
| userEmailValue        | userPasswordValue |
| admin.test3@gmail.com | password123       |
| test.admingmail.com | password456      |

@SmokeTest
Scenario: ValidateLogin
	Given I navigate to authentication page
	When I login with following credentials:
	| userEmail             | userPassword |
	| admin.test3@gmail.com | password123  |
	#When I login with user 'admin.test3@gmail.com'
	#	And password 'password123'
	Then I am loged in