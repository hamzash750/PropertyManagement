﻿using Microsoft.Extensions.Configuration;
using PropertyManagement.Business.Interface;
using PropertyManagement.DAL;
using PropertyManagement.DAL.Model;
using PropertyManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Business.Service
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
        public PropertyAds GetPropertyDetails(int Id)
        {
            return context.PropertyAds.FirstOrDefault(x => x.Id == Id);
        }
        public List<ProductReviewsVM> GetProductReview(int id)
        {
            var prodcut = from p in context.PropertyReviews
                          join user in context.Users
                          on p.UserId equals user.Id
                          where p.PropertyId.Equals(id)
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
    }
}
