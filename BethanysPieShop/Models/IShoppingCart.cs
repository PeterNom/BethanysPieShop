namespace BethanysPieShop.Models
{
    public interface IShoppingCart
    {
        void AddToCart(Pie Pie);
        int RemoveFromCart(Pie Pie);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
