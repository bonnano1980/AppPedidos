﻿using AppPedidos.Domain.Products;

namespace AppPedidos.Domain.Orders
{
    public class OrderItem
    {
        public Product Product { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
