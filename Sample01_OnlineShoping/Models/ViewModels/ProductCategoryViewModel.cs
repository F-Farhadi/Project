using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01_OnlineShoping.Models.ViewModels
{
    public class ProductCategoryViewModel
    {
        #region [- prop -]
        public Models.DomainModel.Services.ProductCategoryService Ref_productcategoryservice { get; set; }
        #endregion


        #region [- FillGrid -]
        public  dynamic FillGrid()
        {

            var q = Infrastructure.Convertor.DtoConvertor(Ref_productcategoryservice.Select());
            return q;
        }
        #endregion

        #region [- Save(Controllers.DTO.DTOCategoryProductController dtocategory) -]
        public void Save(Controllers.DTO.DTOCategoryProductController dtocategory)
        {
            var q = Infrastructure.Convertor.DtoConvertor(dtocategory);
            Ref_productcategoryservice.Insert(q);

        }

        #endregion


        #region [- ShowDetails(int? id) -]
        public dynamic ShowDetails(int? id)
        {
           var q = Infrastructure.Convertor.DtoConvertor(Ref_productcategoryservice.FindId(id));
           return q;

        }

        #endregion


        #region [- Edit(Controllers.DTO.DTOCategoryProductController controllerdto) -]
        public void Edit(Controllers.DTO.DTOCategoryProductController controllerdto)

        {
            Ref_productcategoryservice.UpDate(Infrastructure.Convertor.DtoConvertor(controllerdto));
        }
        #endregion


        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            Ref_productcategoryservice.Delete(id);
        } 
        #endregion
    }

}
