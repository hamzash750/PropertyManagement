using ETrader.DAL.Model;
using ETrader.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.Business.Interface
{
    public interface IPropertyAddService
    {

        List<PropertyAds> getListofProperty();
        PropertyAds GetPropertyDetails(int Id);
        List<ProductReviewsVM> GetProductReview(int Id);
    }
}
