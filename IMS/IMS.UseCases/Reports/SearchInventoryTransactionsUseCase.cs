using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Reports.Interfaces;

namespace IMS.UseCases.Reports
{
    public class SearchInventoryTransactions : ISearchInventoryTransactions
    {
        private readonly IInventoryTransactionRepository inventoryTransactionRepository;

        public SearchInventoryTransactions(IInventoryTransactionRepository inventoryTransactionRepository)
        {
            this.inventoryTransactionRepository = inventoryTransactionRepository;
        }

        public async Task<IEnumerable<InventoryTransaction>> executeAsync(string inventoryName, DateTime? datefrom, DateTime? dateTo, InventoryTransactionType? transactionType)
        {
            if (dateTo.HasValue)
            {
                dateTo = dateTo.Value.AddDays(1);
            }

            return await this.inventoryTransactionRepository.GetInventoryTransactionsAsync(inventoryName, datefrom, dateTo, transactionType);
        }
    }
}