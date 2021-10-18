using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01_OnlineShoping.Models.ViewModels
{
    public class ProductViewModel
    {
        #region [- prop -]
        public Models.DomainModel.Services.ProductService Ref_productservice { get; set; }
        #endregion


        #region [- FillGrid -]
        public dynamic FillGrid()
        {

            var q = Infrastructure.Convertor.DtoConvertor(Ref_productservice.Select());
            return q;
        }
        #endregion

        #region [- Save(Controllers.DTO.DTOProductController dtocategory) -]
        public void Save(Controllers.DTO.DTOProductController dtoproduct)
        {
            var q = Infrastructure.Convertor.DtoConvertor(dtoproduct);
            Ref_productservice.Insert(q);

        }

        #endregion


        #region [- ShowDetails(int? id) -]
        public dynamic ShowDetails(int? id)
        {
            var q = Infrastructure.Convertor.DtoConvertor(Ref_productservice.FindId(id));
            return q;

        }

        #endregion


        #region [- Edit(Controllers.DTO.DTOProductController controllerdto) -]
        public void Edit(Controllers.DTO.DTOProductController controllerdto)

        {
            Ref_productservice.UpDate(Infrastructure.Convertor.DtoConvertor(controllerdto));
        }
        #endregion


        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            Ref_productservice.Delete(id);
        }
        #endregion
    }
}
