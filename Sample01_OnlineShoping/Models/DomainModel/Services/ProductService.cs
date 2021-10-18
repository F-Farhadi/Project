using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sample01_OnlineShoping.Models.DomainModel.Services
{
    public class ProductService
    {

        #region [- prop -]
        public Models.DomainModel.Aggregations.ProductAggregation.Product Ref_Product { get; set; }

        #endregion    }




        #region [- Select() -]
        public List<Models.DomainModel.Aggregations.ProductAggregation.Product> Select()
        {
            using (var context = new Models.EFCore.OnlineShopDbContext())
            {
                try
                {

                    var q = context.Product.Include(p=> p.Category).ToList();
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

        #region [- FillCategory -]
        public List<Models.DomainModel.Aggregations.ProductAggregation.ProductCategory> FillCategory()
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

        #region [- Insert(Models.DomainModel.Aggregations.ProductAggregation.Product product) -]
        public void Insert(Models.DomainModel.Aggregations.ProductAggregation.Product product)
        {
            using (var context = new Models.EFCore.OnlineShopDbContext())
            {
                try
                {
                    context.Product.Add(product);
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
        public Models.DomainModel.Aggregations.ProductAggregation.Product FindId(int? id)
        {
            using (var context = new Models.EFCore.OnlineShopDbContext())
            {
                try
                {
                    var q = context.Product.Find(id);

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
                    var q = context.Product.Find(id);
                    context.Product.Remove(q);
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


        #region [- UpDate(Models.DomainModel.Aggregations.ProductAggregation.Product product) -]
        public void UpDate(Models.DomainModel.Aggregations.ProductAggregation.Product product)
        {
            using (var context = new Models.EFCore.OnlineShopDbContext())
            {
                try
                {
                    context.Entry(product).State = EntityState.Modified;
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
        #endregion    }
    }
}