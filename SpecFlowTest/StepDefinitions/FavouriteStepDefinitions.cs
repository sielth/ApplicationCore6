using Microsoft.eShopWeb.ApplicationCore.Entities.FavouriteAggregate;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public sealed class  FavouriteStepDefinitions
    {
        private int id;
        private decimal _price;
        private readonly Favourite favourite = new Favourite("buyer1");

        [Given("A Favourite Item (.*),(.*)")]
        public void GivenTheFirstItemIs(int catalogItemId, decimal price)
        {
            id = catalogItemId;
            _price = price;
        }

        [When("The item is added to FavouriteBasket")]
        public void WhenTheItemIsAddedToFavouriteBasket()
        {
            favourite.AddItem(id, _price);
        }

        [Then("The item should be in the FavouriteBasket")]
        public void ThenTheItemShouldBeInFavouriteBasket()
        {
            favourite.Items.Should().Contain(x => x.CatalogItemId == id && x.UnitPrice == _price);
        }


        [Given("A Favourite Item id (.*)")]
        
        public void GivenItemId(int catalogItemId)
        {
            id = catalogItemId;
           
        }

        [When("The item is deleted from FavouriteBasket")]
        public void WhenTheItemIsDeletedFromFavouriteBasket()
        {
            favourite.Delete(id);
                }

        [Then("The item should be removed from FavouriteBasket")]
        public void ThenTheItemShouldBeRremovedFromFavouriteBasket()
        {
            favourite.Items.Should().NotContain(x=> x.CatalogItemId == id);
        }


    }
}