Feature: AuthentificationPage
	In order to check login
	As a admin user
	I want to authenticate into casqad.org

@LoginwithUserDto
Scenario: ValidateLoginUsingDto
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail             | userPassword |
	| admin.test3@gmail.com | password123  |
	Then I am logged in