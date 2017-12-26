using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.Item
{
    public class InventoryItem : Item
    {
        #region string
        public string BarcodeUPC { get; set; }
        public string SKU { get; set; }
        public string ModelName { get; set; }
        #endregion

        #region int
        public int ManufacturerID { get; set; }
        public int BrandID { get; set; }
        public int StockOnHand { get; set; }
        public int OpeningStock { get; set; }
        public int IncomeAccountID { get; set; }
        public int COGSID { get; set; }
        public int AssetsAccountID { get; set; }
        #endregion

        #region bool
        public bool IsTaxable { get; set; }
        public bool IsSerial { get; set; }
        #endregion

        #region decimal
        public decimal SalePrice { get; set; }
        public decimal Wieght { get; set; }
        public decimal Volume { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        #endregion
    }
}
