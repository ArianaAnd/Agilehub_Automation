Feature: Demoqa
	In order to practice my automation skills
	As a tester
	I want to be able to create an account and fill in a text form on demoqa.com

@CreateDemoQaAccount

	Given I go to the 'https://demoqa.com/automation-practice-form' website
	When I fill in the registration form
	| FirstName       | LastName       | Email         | Gender | MobilePhone| DateOfBirth | Subjects                         | Hobbies        | PictureName  | CurrentAddress          | State   | City   |
	| Ariana		  | A              | test@test.com | Female | 0711111111 | 25/09/1997  | Computer Science, Maths, Physics | Reading, Music | images.jpg   | CurrentStreet 1, BV, RO | Haryana | Panipat|
	Then I should see the confirmation that the form was submitted

@DemoQaTextBox

Scenario: DemoQaTextBox
	Given I go to the 'https://demoqa.com/text-box' website
	When I fill in the text box form
	| FullName            | Email         | CurrentAddress          | PermanentAddress |
	| Ariana | test@test.com | CurrentStreet 1, BV, RO | PermanentStreet 1, BV, RO |