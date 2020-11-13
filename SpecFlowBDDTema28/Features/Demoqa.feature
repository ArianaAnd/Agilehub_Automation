Feature: Demoqa
	In order to practice my automation skills
	As a tester
	I want to be able to create an account and fill in a text form on demoqa.com

@CreateDemoQaAccount
Scenario: CreateDemoQaAccount
	Given I go to the 'https://demoqa.com/automation-practice-form' website
	When I fill in the registration form
	| FirstName       | LastName       | Email             | Gender | MobilePhone | DateOfBirth | Subjects             | Hobbies       | PictureName  | CurrentAddress               | State   | City    |
	| Test First Name | Test Last Name | testuser@test.com | Female | 4123456789  | 03/12/1970  | Maths, Arts, English | Sports, Music | test-img.JPG | My current street 11, BV, RO | Haryana | Panipat |
	Then I should see the confirmation that the form was submitted

@DemoQaTextBox
Scenario: DemoQaTextBox
	Given I go to the 'https://demoqa.com/text-box' website
	When I fill in the text box form
	| FullName            | Email         | CurrentAddress          | PermanentAddress |
	| Ariana | test@test.com | CurrentStreet 1, BV, RO | PermanentStreet 1, BV, RO |