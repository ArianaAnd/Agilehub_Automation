Feature: AddToCartAdmin
	In order to add a product to cart
	I want to authenticate as an admin
	And then I want to add product to cart

@mytag
Scenario Outline: AddToCartAdmin
	Given I login with admmin
		| userEmail        | userPassword        |
		| <userEmailValue> | <userPasswordValue> |
	When I add a product in the cart
	Then I see the product in the cart

	Examples: 
| userEmailValue        | userPasswordValue |
| admin.test3@gmail.com | password123       |