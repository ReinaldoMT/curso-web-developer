using Domain.Commands;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.CommandHandlers
{
    public class CommandHandler
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductRepository _productRepository;

        public List<string> Errors { get; set; }
        public CommandHandler(IOrderRepository orderRepository,
            IOrderItemRepository orderItemRepository,
            ICustomerRepository customerRepository,
            IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            Errors = new List<string>();
        }

        public void Execute(StartDataCommand command)
        {
            if (!command.IsValid())
            {
                Errors = command.ErrorMessages;
            }

            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                IsActive = true,
                Name = "Reinaldo"
            };

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Notebook Dell",
                Price = 4000,
                Sku = "77655"
            };


            _customerRepository.Set(customer);
            _productRepository.Set(product);

            for (var i = 1; i <= 10; i++)
            {
                var order = new Order
                {
                    Id = Guid.NewGuid(),
                    Number = i,
                    CustomerId = customer.Id,
                };

                var quantity = i;
                var orderItem = new OrderItem
                {
                    Id = Guid.NewGuid(),
                    OrderId = order.Id,
                    Price = product.Price,
                    Quantity = quantity,
                    ProductId = product.Id,
                    Total = product.Price * quantity
                };

                _orderRepository.Set(order);
                _orderItemRepository.Set(orderItem);
            }
        }
    }
}
