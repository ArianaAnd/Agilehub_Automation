Feature: AddToCartPage
	In order to buy a product
	As a client user
	I want to be able to add products to the cart

@AddToCartAsUser
Scenario: AddToCartAsUser
	Given I navigate to home page
	When I add a product in the cart
	Then I need to login to complete the action

#	Scenario Outline: AddToCartUser
#	Given I login with user
#		| userEmail        | userPassword        |
#		| <userEmailValue> | <userPasswordValue> |
#	When I add a product in the cart
#	Then I need to login to complete the action
#
#	Examples: 
#| userEmailValue        | userPasswordValue |
#| Ariana@gmail.com		 | parola123         |
#| admin.test3@gmail.com | password123       |

@AddToCartAsAdmin
Scenario: AddToCartAsAdmin
	Given I am logged in as admin
	When I add a product to the cart
	Then I see the order button in my cart


