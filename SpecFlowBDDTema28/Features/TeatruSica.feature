Feature: TeatruSica
	In order to buy a theatre ticket
	As a spectator
	I want to be able to see the shows details

@mytag
Scenario: TeatruSica
	Given I go to the 'https://www.teatrulsicaalexandrescu.ro/?lang=en' website
	When I go to the first actor page
		And I choose the first show
	Then I should have the option to buy a ticket