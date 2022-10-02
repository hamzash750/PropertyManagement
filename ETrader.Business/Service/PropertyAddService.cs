using Microsoft.Extensions.Configuration;
using ETrader.Business.Interface;
using ETrader.DAL;
using ETrader.DAL.Model;
using ETrader.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.Business.Service
{
    public class PropertyAddService : IPropertyAddService
    {
        private MyContext context = null;
        private IConfiguration configuration;
        public PropertyAddService(MyContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public List<PropertyAds> getListofProperty()
        {
          return context.PropertyAds.ToList();
        }
        public List<PropertyAds> getListofCategory(int catID)
        {
            return context.PropertyAds.Where(x=>x.CategoryId== catID).ToList();
        }
        public PropertyAdsVM GetPropertyDetails(int Id)
        {
            var obj = new PropertyAdsVM();
            var details= context.PropertyAds.FirstOrDefault(x => x.Id == Id);
            if (details != null)
            {

                obj.Area = details.Area;
                obj.AreaUnit = details.AreaUnit;
                obj.Baths = details.Baths;
                obj.Bed = details.Bed;
                obj.CategoryId = details.CategoryId;
                obj.Category = context.PropertyCategorys.FirstOrDefault(x=>x.Id==details.CategoryId)?.Tittle;
                obj.Description = details.Description;
                obj.Garage = details.Garage;
                obj.Id = details.Id;
                obj.Images = details.Images;
                obj.Kitchen = details.Kitchen;
                obj.Location = details.Location;
                obj.ModifiedDate = details.ModifiedDate;
                obj.OtherAmenites = details.OtherAmenites;
                obj.Pool = details.Pool;
                obj.PostDate = details.PostDate;
                obj.Price = details.Price;
                obj.SellerId = details.SellerId;
                obj.Quantity = details.Quantity;
                obj.Tittle = details.Tittle;
                var sellerDetails = context.Users.FirstOrDefault(x => x.Id == details.SellerId);
                if (sellerDetails != null)
                {
                    obj.UserName = sellerDetails.Name;
                    obj.Email = sellerDetails.Email;
                    obj.Address = sellerDetails.Address;
                    obj.Phone = sellerDetails.Phone;
                }
            }
            return obj;
        }
        public List<ProductReviewsVM> GetProductReview(int id)
        {
            var prodcut = from p in context.PropertyReviews
                          join user in context.Users
                          on p.UserId equals user.Id
                          where p.SellerId.Equals(id)
                          select new ProductReviewsVM
                          {
                              CreateAt = p.CreateAt,
                              User = user.Name,
                              Rate = p.Rate,
                              ReviewComents = p.ReviewComents,
                              ReviewTittle=p.ReviewTittle
                          };
            return prodcut.ToList();
        }

        public List<PropertyCategory> getListOfPropertyCategory()
        {
            return context.PropertyCategorys.ToList();
        }

        public int SaveProperty(PropertyAds propertyAds)
        {
            if (propertyAds.Id > 0)
            {
                var add = context.PropertyAds.Update(propertyAds);
                context.SaveChanges();
            }
            else
            {

                var add = context.PropertyAds.Add(propertyAds);
                context.SaveChanges();
            }
          
            return 1;
        }

        public List<PropertyAds> searchProperty(SearchVM obj)
        {
            var list = context.PropertyAds.ToList();
            if (!string.IsNullOrEmpty(obj.Property) && !string.IsNullOrWhiteSpace(obj.Property))
            {
                list = list.Where(x => x.Tittle.ToLower().Contains(obj.Property.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(obj.Location) && !string.IsNullOrWhiteSpace(obj.Location))
            {
                list = list.Where(x => x.Location.ToLower().Contains(obj.Location.ToLower())).ToList();
            }
            if (obj.Type>0)
            {
                list = list.Where(x => x.CategoryId==obj.Type).ToList();
            }
            if (obj.Beds > 0)
            {
                list = list.Where(x => x.Bed <= obj.Beds).ToList();
            }
            if (obj.Bath > 0)
            {
                list = list.Where(x => x.Baths <= obj.Bath).ToList();
            }
            if (obj.PriceMin > 0&&obj.PriceMax>0)
            {
                list = list.Where(x => x.Price>=obj.PriceMin&&x.Price<=obj.PriceMax).ToList();
            }
            return list;
        }
        public List<PropertyAds> getLatestofProperty()
        {
            return context.PropertyAds.OrderByDescending(x=>x.Id).Take(5).ToList();
        }
        public List<PropertyAds> getAgentPropertyList(int agentId)
        {
            return context.PropertyAds.Where(x => x.SellerId == agentId).ToList();
        }
        public int deleteProperty(int Id)
        {
            var findProperty = context.PropertyAds.FirstOrDefault(x => x.Id == Id);
            if (findProperty != null)
            {
                context.PropertyAds.Remove(findProperty);
                context.SaveChanges();
                return 1;
            }
            
            return 0;
        }

        public List<PropertyAds> getBuyerPropertyList(int BuyerId)
        {
            var list = new List<PropertyAds>();
            var findAllBuyerProeperty = context.PropertySales.Where(x => x.BuyerId == BuyerId).ToList();
            if (findAllBuyerProeperty.Count > 0)
            {
                foreach (var item in findAllBuyerProeperty)
                {
                    var findProperty = context.PropertyAds.FirstOrDefault(x => x.Id == item.PropertyId);
                    if (findProperty != null)
                    {
                        list.Add(findProperty);
                    }
                }
               
            }
            return list;
        }

        public List<PropertyFinderVM> getAllRequest()
        {
            var list = new List<PropertyFinderVM>();
            var findallRequest = context.PropertyFinders.ToList();
            foreach (var item in findallRequest)
            {
                var obj = new PropertyFinderVM();
                obj.DateTime = item.DateTime;
                obj.Description = item.Description;
                obj.PriceExpectations = item.PriceExpectations;
                obj.Title = item.Title;
                var findUser = context.Users.FirstOrDefault(x => x.Id == item.UserId);
                if (findUser != null)
                {
                    obj.UserName = findUser.Name;
                    obj.UserPhone = findUser.Phone;
                    obj.UserEmail = findUser.Email;
                }
                list.Add(obj);

            }
            return list;
        }

        public int postFinderRequest(PropertyFinder obj)
        {
            obj.DateTime = DateTime.Now;
            context.PropertyFinders.Add(obj);
            context.SaveChanges();
            return 1;
            
        }

       
        public List<PropertyFinderVM> getAllUserRequest(int Id)
        {
            var list = new List<PropertyFinderVM>();
            var findallRequest = context.PropertyFinders.Where(x=>x.UserId==Id).ToList();
            foreach (var item in findallRequest)
            {
                var obj = new PropertyFinderVM();
                obj.Id = item.Id;
                obj.DateTime = item.DateTime;
                obj.Description = item.Description;
                obj.PriceExpectations = item.PriceExpectations;
                obj.Title = item.Title;
                var findUser = context.Users.FirstOrDefault(x => x.Id == item.UserId);
                if (findUser != null)
                {
                    obj.UserName = findUser.Name;
                    obj.UserPhone = findUser.Phone;
                    obj.UserEmail = findUser.Email;
                }
                list.Add(obj);

            }
            return list;
        }
        public int deleteRequest(int Id)
        {
            var findRequest = context.PropertyFinders.FirstOrDefault(x => x.Id == Id);
            if (findRequest != null)
            {
                context.PropertyFinders.Remove(findRequest);
                context.SaveChanges();
                return 1;
            }
            return 0;
        }

        public int postPropertyReview(PropertyReviews obj)
        {
            obj.CreateAt = DateTime.Now;
            context.PropertyReviews.Add(obj);
            context.SaveChanges();
            return 1;
        }

        public DashboardVM GetUserDashboardData(int UserId)
        {
            var obj = new DashboardVM();
            obj.SalePropertyCount = context.PropertyAds.Where(x => x.SellerId == UserId).ToList().Count;
            obj.PurchasePropertyCount = context.PropertySales.Where(x => x.BuyerId == UserId).ToList().Count;
            obj.TotalAmount = context.PropertySales.Where(x => x.BuyerId == UserId).ToList().Sum(x=>x.PaidAmount);
            obj.TotalFinderRequset = context.PropertyFinders.Where(x => x.UserId == UserId).Count();
            obj.TotalReviews = context.PropertyReviews.Where(x => x.UserId == UserId).ToList().Count();
            obj.TotalChat = context.PropertyChats.Where(x => x.SellerId == UserId || x.BuyerId == UserId).ToList().Count();
            return obj;

        }

        public List<UserChatVM> GetUserChatList(int User)
        {
            var ChatList = new List<UserChatVM>();
            var FindAllUserChat = context.PropertyChats.Where(x => x.SellerId == User || x.BuyerId == User).ToList();
            foreach (var item in FindAllUserChat)
            {
                var obj = new UserChatVM();
                if (item.SellerId != User)
                {
                    obj.UserId = item.SellerId;
                }
                if (item.BuyerId != User)
                {
                    obj.UserId = item.BuyerId;
                }
                var UserDetails=context.Users.FirstOrDefault(x => x.Id == obj.UserId);
                if (UserDetails!=null)
                {
                    obj.UserName = UserDetails.Name;
                }
                var checkUniqUser = ChatList.FirstOrDefault(x => x.UserId == obj.UserId);
                if (checkUniqUser==null)
                {
                    ChatList.Add(obj);
                }
              
            }
            return ChatList.Distinct().ToList();

        }
        public List<UserChatVM> GetUserChatDetails(int User,int buyerId)
        {
            var ChatList = new List<UserChatVM>();
            var FindAllUserChat = context.PropertyChats.Where(x => (x.SellerId == User && x.BuyerId == buyerId) || (x.BuyerId == User && x.SellerId == buyerId)).ToList();
            foreach (var item in FindAllUserChat)
            {
                var obj = new UserChatVM();
                obj.DateTime = item.DateTime;
                if (item.SellerId != User)
                {
                    obj.UserId = item.SellerId;
                }
                if (item.BuyerId != User)
                {
                    obj.UserId = item.BuyerId;
                }
                var UserDetails = context.Users.FirstOrDefault(x => x.Id == obj.UserId);
                if (UserDetails != null)
                {
                    obj.UserName = UserDetails.Name;
                }

                obj.UserChat = item.Message;
                ChatList.Add(obj);
            }
            return ChatList.Distinct().ToList();

        }

        public int saveNewMessage(PropertyChat obj)
        {
            obj.DateTime = DateTime.Now;
            context.PropertyChats.Add(obj);
            context.SaveChanges();
            return 1;
        }

        public int SavePropertySale(PropertySale obj)
        {
            context.PropertySales.Add(obj);
            context.SaveChanges();
            return 1;
        }
    }
}
