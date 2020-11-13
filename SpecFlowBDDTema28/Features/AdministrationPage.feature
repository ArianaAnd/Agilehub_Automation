Feature: AdministrationPage
	In order to manage the website
	As a admin user
	I want to be able to edit users

@AdminMenu
Scenario: Access menu
	iven I am logged in as admin
	When I navigate to Administration page
	Then I see the Site menu
@UserMenu
Scenario: AccessUsersMenu
	Given I am logged in as admin
	When I go to Users page in the Administration section
	Then I see the users list
	@EditUser
Scenario: EditUser
	Given I am logged in as admin
	When I go to Users page in the Administration section
		And I edit the user 'ad_demo@test.com'
	Then The user should be updated