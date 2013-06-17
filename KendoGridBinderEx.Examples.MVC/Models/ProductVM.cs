﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using FluentValidation.Attributes;
using KendoGridBinderEx.Examples.MVC.Data.Entities;
using KendoGridBinderEx.Examples.MVC.Data.Validation;

namespace KendoGridBinderEx.Examples.MVC.Models
{
    [Table("KendoGrid_Product")]
    [Validator(typeof(ProductValidator))]
    public class ProductVM : Entity
    {
        [Remote("IsCodeUnique", "Product", AdditionalFields = "Id")]
        public string Code { get; set; }

        public string Name { get; set; }
    }
}