using Medical.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Medical.Products;
public class ProductAppService :
    CrudAppService<
      Product, //The Book entity
        ProductDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateProductDto>, //Used to create/update a book
    IProductAppService //implement the IBookAppService
    {   
            public ProductAppService(IRepository<Product, Guid> repository)
                : base(repository)
            {
                GetPolicyName = MedicalPermissions.Products.Default;
                GetListPolicyName = MedicalPermissions.Products.Default;
                CreatePolicyName = MedicalPermissions.Products.Create;
                UpdatePolicyName = MedicalPermissions.Products.Edit;
                DeletePolicyName = MedicalPermissions.Products.Delete;
            }

    }

