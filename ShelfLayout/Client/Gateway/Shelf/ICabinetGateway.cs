﻿using ShelfLayout.Shared.Entities.Response.Shelf;

namespace ShelfLayout.Client.Gateway.Shelf
{
    public interface ICabinetGateway
    {
        Task<CabinetResponse> GetAsync(int storeId, int cabinetId);
    }
}
