Feature: Favourite

A short summary of the feature

@AddItemToBasket
 Scenario:Add Items To FavouriteBasket
	Given A Favourite Item 1,2
	When  The item is added to FavouriteBasket
	Then  The item should be in the FavouriteBasket


	Scenario:Delete A FavouriteItem From FavouriteBasket
	Given A Favourite Item id  1
	When  The item is deleted from FavouriteBasket
	Then  The item should be removed from FavouriteBasket


