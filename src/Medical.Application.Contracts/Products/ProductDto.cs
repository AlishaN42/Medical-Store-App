﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Medical.Products;
public class ProductDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public ProductType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
}