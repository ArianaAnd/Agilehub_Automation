Feature: LoginAndLogout
	In order logout from Demosite.Casqad site
	I login 

@mytag
Scenario Outline: LoginAndLogout
	Given I am logged on site with following credentials
		| userEmail        | userPassword        |
		| <userEmailValue> | <userPasswordValue> |
	When I click disconnect button
	Then I am successfully logged out

	Examples: 
| userEmailValue       | userPasswordValue |
| ariana.andrisan@yahoo.com | password124  |