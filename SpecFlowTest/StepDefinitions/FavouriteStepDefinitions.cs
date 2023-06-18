using Microsoft.eShopWeb.ApplicationCore.Entities.FavouriteAggregate;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class FavouriteStepDefinitions
    {
        private int id;
        private readonly Favourite favourite = new Favourite("buyer1");

        [Given("an item with id (.*)")]
        public void GivenAnItemWithId(int catalogItemId)
        {
            id = catalogItemId;
        }

        [When("the item is added into the favourite list")]
        public void WhenTheItemIsAddedIntoTheFavouriteList()
        {
            favourite.AddItem(id, _price);
        }

        [Then("the favourite list should contain the item with id (.*)")]
        public void ThenTheFavouriteListShouldContainTheItemWithId(int id)
        {
            favourite.Items.Should().Contain(x => x.CatalogItemId == id && x.UnitPrice == _price);
        }


        [Given("a favourite list that contains an item with id (.*)")]
        public void GivenAFavouriteListThatContainsAnItemWithId(int catalogItemId)
        {
            id = catalogItemId;
        }

        [When("The item is deleted from favourite list")]
        public void WhenTheItemIsDeletedFromFavouriteBasket()
        {
            favourite.Delete(id);
        }

        [Then("the favourite list should not contain the item with id (.*)")]
        public void ThenTheItemShouldBeRremovedFromFavouriteBasket()
        {
            favourite.Items.Should().NotContain(x=> x.CatalogItemId == id);
        }
    }
}
