using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
namespace Sample01_OnlineShoping.Models.DomainModel.Services
{
    public class ProductCategoryService
    {
        #region [- prop -]
        public Models.DomainModel.Aggregations.ProductAggregation.ProductCategory Ref_Productcategory { get; set; }

        #endregion    }



        #region [- Select() -]
        public List<Models.DomainModel.Aggregations.ProductAggregation.ProductCategory> Select()
        {
            using (var context = new Models.EFCore.OnlineShopDbContext())
            {
                try
                {

                    var q = context.ProductCategory.ToList();
                    return q;

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }

            }



        }
        #endregion

        #region [- Insert(Models.DomainModel.Aggregations.ProductAggregation.ProductCategory productcategory) -]
        public void Insert(Models.DomainModel.Aggregations.ProductAggregation.ProductCategory productcategory)
        {
            using (var context = new Models.EFCore.OnlineShopDbContext())
            {
                try
                {
                    context.ProductCategory.Add(productcategory);
                    context.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }



            }

        }
        #endregion


        #region [- FindId(int? id) -]
        public Models.DomainModel.Aggregations.ProductAggregation.ProductCategory FindId(int? id)
        {
            using (var context = new Models.EFCore.OnlineShopDbContext())
            {
                try
                {
                    var q = context.ProductCategory.Find(id);

                    return q;

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }

            }



        }

        #endregion


        #region [- Delete(int? id) -]
        public void Delete(int? id)
        {
            using (var context = new Models.EFCore.OnlineShopDbContext())
            {
                try
                {
                    var q = context.ProductCategory.Find(id);
                    context.ProductCategory.Remove(q);
                    context.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }

            }
        }
        #endregion


        #region [- UpDate(Models.DomainModel.Aggregations.ProductAggregation.ProductCategory productcategory) -]
        public void UpDate(Models.DomainModel.Aggregations.ProductAggregation.ProductCategory productcategory)
        {
            using (var context = new Models.EFCore.OnlineShopDbContext())
            {
                try
                {
                    context.Entry(productcategory).State = EntityState.Modified;
                    context.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }

            }


        }
        #endregion
    }
}