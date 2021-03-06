﻿using DShop.Common.Types;
using DShop.Api.Models.Orders;
using DShop.Api.Models.Queries;
using RestEase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DShop.Api.Services
{
    [SerializationMethods(Query = QuerySerializationMethod.Serialized)]
    public interface IOrdersService
    {
        [AllowAnyStatusCode]
        [Get("orders/{id}")]
        Task<OrderDetails> GetAsync([Path] Guid id);

        [AllowAnyStatusCode]
        [Get("orders")]
        Task<PagedResult<Order>> BrowseAsync([Query] BrowseOrders query);
    }
}
