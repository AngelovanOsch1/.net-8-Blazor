using IMS.CoreBusiness;

namespace IMS.UseCases.Reports.Interfaces
{
    public interface ISearchInventoryTransactions
    {
        Task<IEnumerable<InventoryTransaction>> executeAsync(string inventoryName, DateTime? datefrom, DateTime? dateTo, InventoryTransactionType? transactionType);
    }
}