﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SuperShop.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} can contain {1} characters length.")]
        public string Name { get; set; }


        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }


        [Display(Name = "Image")]
        //public string ImageUrl {  get; set; }
        public Guid ImageId { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase {  get; set; }


        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }


        [Display(Name = "Is Avaiable")]
        public bool IsAvaiable { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock {  get; set; }

        public User User { get; set; }

        public string ImageFullPath => ImageId == Guid.Empty
            ? $"images/noimage.png"   
			: $"images/products/{ImageId}.png"; 
        
    }
}
