using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Medical.Products;
public class CreateUpdateProductDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; }

    [Required]
    public ProductType Type { get; set; } = ProductType.Undefined;

    [Required]
    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; } = DateTime.Now;

    [Required]
    public float Price { get; set; }
}