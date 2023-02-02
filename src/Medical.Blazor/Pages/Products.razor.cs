

/*using Medical.Products;
using Medical.Permissions;
using Blazorise;
using Blazorise.DataGrid;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Medical.Blazor.Pages;

public partial class Products
{
    private IReadOnlyList<ProductDto> ProductList { get; set; }

   
    private bool CanCreateProduct { get; set; }
    private bool CanEditProduct { get; set; }
    private bool CanDeleteProduct { get; set; }

    private CreateUpdateProductDto NewProduct { get; set; }

   
    private CreateUpdateProductDto EditingProduct { get; set; }

    private Modal CreateProductModal { get; set; }
    private Modal EditProductModal { get; set; }

  
    public Products()
    {
        NewProduct = new CreateUpdateProductDto();
        EditingProduct = new CreateUpdateProductDto();
    }
    protected override async Task OnInitializedAsync()
    {
        await SetPermissionsAsync();
       
    }

    private async Task SetPermissionsAsync()
    {
        CanCreateProduct = await AuthorizationService
            .IsGrantedAsync(MedicalPermissions.Products.Create);

        CanEditProduct = await AuthorizationService
            .IsGrantedAsync(MedicalPermissions.Products.Edit);

        CanDeleteProduct = await AuthorizationService
            .IsGrantedAsync(MedicalPermissions.Products.Delete);
    }

    private async Task OnDataGridReadAsync(DataGridReadDataEventArgs<ProductDto> e)
    {
        CurrentSorting = e.Columns
            .Where(c => c.SortDirection != SortDirection.Default)
            .Select(c => c.Field + (c.SortDirection == SortDirection.Descending ? " DESC" : ""))
            .JoinAsString(",");
        CurrentPage = e.Page - 1;

        await InvokeAsync(StateHasChanged);
    }

    

    private void CloseCreateProductModal()
    {
        CreateProductModal.Hide();
    }

    private void OpenEditProductModal(ProductDto author)
    {
        EditValidationsRef.ClearAll();

        EditProductModal.Show();
    }

    private async Task DeleteProductAsync(ProductDto Product)
    {
        var confirmMessage = L["ProductDeletionConfirmationMessage", Product.Name];
        if (!await Message.Confirm(confirmMessage))
        {
            return;
        }

      
       
    }

    private void CloseEditProductModal()
    {
        EditProductModal.Hide();
    }

    private async Task CreateProductAsync()
    {
        if (await CreateValidationsRef.ValidateAll())
        {
           
            CreateProductModal.Hide();
        }
    }

   
}*/
