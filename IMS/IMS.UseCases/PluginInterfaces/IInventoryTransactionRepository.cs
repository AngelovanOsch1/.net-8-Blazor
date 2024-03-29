﻿using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IInventoryTransactionRepository
    {
        void PurchaseAsync(string poNumber, Inventory inventory, int quantity, string doneBy, double price);

        void ProduceAsync(string productionNumber, Inventory inventory, int quantityToConsume, string doneBy, double price);

        Task<IEnumerable<InventoryTransaction>> GetInventoryTransactionsAsync(string inventoryName, DateTime? datefrom, DateTime? dateTo, InventoryTransactionType? transactionType);
    }
}