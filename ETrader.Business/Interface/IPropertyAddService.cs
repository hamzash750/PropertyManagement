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
        List<PropertyAds> getListofCategory(int catID);
        PropertyAdsVM GetPropertyDetails(int Id);
        List<ProductReviewsVM> GetProductReview(int Id);
        List<PropertyCategory> getListOfPropertyCategory();
        int SaveProperty(PropertyAds propertyAds);
        List<PropertyAds> searchProperty(SearchVM obj);
        List<PropertyAds> getLatestofProperty();
        List<PropertyAds> getAgentPropertyList(int AgendId);
        int deleteProperty(int Id);
        List<PropertyAds> getBuyerPropertyList(int BuyerId);
        List<PropertyFinderVM> getAllRequest();
        int postFinderRequest(PropertyFinder obj);
        List<PropertyFinderVM> getAllUserRequest(int Id);
        int deleteRequest(int Id);
        int postPropertyReview(PropertyReviews obj);
        DashboardVM GetUserDashboardData(int Id);
        List<UserChatVM>  GetUserChatList(int Id);
        List<UserChatVM> GetUserChatDetails(int Id, int buyerId);
        int saveNewMessage(PropertyChat obj);
        int SavePropertySale(PropertySale obj);
    }
}
