using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01_OnlineShoping.Infrastructure
{
    public static class Convertor
    {
        
        #region [- DtoConvertor(Controllers.DTO.DTOCategoryProductController dto) -]
        public static Models.DomainModel.Aggregations.ProductAggregation.ProductCategory DtoConvertor(Controllers.DTO.DTOCategoryProductController dto)
        {

            Models.DomainModel.Aggregations.ProductAggregation.ProductCategory models = new Models.DomainModel.Aggregations.ProductAggregation.ProductCategory();
            dto.ID = models.ID;
            dto.Title = models.Title;
            dto.Code = models.Code;
            return models;
        } 
        #endregion

        
        #region [- DtoConvertor(Controllers.DTO.DTOProductController dto) -]
        public static Models.DomainModel.Aggregations.ProductAggregation.Product DtoConvertor(Controllers.DTO.DTOProductController dto)
        {
            Models.DomainModel.Aggregations.ProductAggregation.Product models = new Models.DomainModel.Aggregations.ProductAggregation.Product();
            models.ID = dto.ID;
            models.ProductName = dto.ProductName;
            models.Code = dto.Code;
            models.CategoryRef = dto.CategoryRef;
            models.UnitPrice = dto.UnitPrice;
            return models;

        }
        #endregion

        #region [- DtoConvertor(list<Models.DomainModel.Aggregations.ProductAggregation.ProductCategory> modellist) -]
        public static List <Controllers.DTO.DTOCategoryProductController> DtoConvertor(List < Models.DomainModel.Aggregations.ProductAggregation.ProductCategory> modellist)
        {
           List <Controllers.DTO.DTOCategoryProductController> dtolist = new List<Controllers.DTO.DTOCategoryProductController>();
            foreach (var item in modellist)
            {
                var dto =new Controllers.DTO.DTOCategoryProductController();
                dto.ID = item.ID;
                dto.Title = item.Title;
                dto.Code = item.Code;
                dtolist.Add(dto);
               
            }

            return dtolist;

        }

        #endregion


        #region [- DtoConvertor(list<Models.DomainModel.Aggregations.ProductAggregation.Product> models) -]
        public static List<Controllers.DTO.DTOProductController> DtoConvertor(List<Models.DomainModel.Aggregations.ProductAggregation.Product> models)
        {
            List<Controllers.DTO.DTOProductController> dtolist = new List<Controllers.DTO.DTOProductController>();
            foreach (var item in models)
            {
                var dto = new Controllers.DTO.DTOProductController();
                dto.ID = item.ID;
                dto.ProductName = item.ProductName;
                dto.Code = item.Code; 
                dto.CategoryRef = item.CategoryRef;
                dto.UnitPrice = item.UnitPrice;
                dtolist.Add(dto);

            }
            return dtolist;
        }
        #endregion


        #region [- DtoConvertor(Models.DomainModel.Aggregations.ProductAggregation.Product model) -]

        public static Controllers.DTO.DTOProductController DtoConvertor(Models.DomainModel.Aggregations.ProductAggregation.Product model)
        {
            var dto = new Controllers.DTO.DTOProductController();
            dto.ID = model.ID;
            dto.ProductName = model.ProductName;
            dto.Code = model.Code;
            dto.CategoryRef = model.CategoryRef;
            dto.UnitPrice = model.UnitPrice;
            return dto;
        }
        #endregion

        #region [-  DtoConvertor(Models.DomainModel.Aggregations.ProductAggregation.ProductCategory model) -]
        public static Controllers.DTO.DTOCategoryProductController DtoConvertor(Models.DomainModel.Aggregations.ProductAggregation.ProductCategory model)
        {
            var dto = new Controllers.DTO.DTOCategoryProductController();
            dto.ID = model.ID;
            dto.Title = model.Title;
            dto.Code = model.Code;
            return dto;
        } 
        #endregion
    }

}