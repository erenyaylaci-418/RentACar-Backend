using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete.ImageEntity
{
    public class CarImage : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImageName { get; set; }
        public DateTime AddDate { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
