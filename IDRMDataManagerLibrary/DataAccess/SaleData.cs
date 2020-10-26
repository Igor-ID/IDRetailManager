using IDRMDataManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDRMDataManagerLibrary.DataAccess
{
    public class SaleData
    {
        //public List<ProductModel> GetProducts()
        //{
        //    SqlDataAccess sql = new SqlDataAccess();

        //    var output = sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { }, "IDRMData");

        //    return output;
        //}

        public void SaveSale(SaleModel sale)
        {
            //TODO: Make this SOLID/DRY/Better
            // Start filling in the models we will save to the database
            List<SaleDetailDBModel> details = new List<SaleDetailDBModel>();
            ProductData products = new ProductData();

            foreach (var item in sale.SaleDetails)
            {
                var detail = new SaleDetailDBModel
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                };

                // Get the information about this product
                var productInfo = products.GetProductById(detail.ProductId);

                if (productInfo == null)
                {
                    throw new Exception($"The product Id of {detail.ProductId} could not be found in the database.");
                }

                detail.PurchasePrice = productInfo.RetailPrice * detail.Quantity;

                details.Add(detail);
            }

            // Fill in the available information
            // Create the Sale model
            // Get the ID from the sale model
            // Finish filling in the sale detail models
            // Save the sale detail models
        }
    }
}
