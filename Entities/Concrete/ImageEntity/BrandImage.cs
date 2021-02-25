using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete.ImageEntity
{
    public class BrandImage :IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string ImageName { get; set; }
        public DateTime AddDate { get; set; }
        [NotMapped]
        public IFormFile MyProperty { get; set; }
    }
}
