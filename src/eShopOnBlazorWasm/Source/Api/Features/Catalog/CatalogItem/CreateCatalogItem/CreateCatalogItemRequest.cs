namespace eShopOnBlazorWasm.Features.Catalog
{
  using eShopOnBlazorWasm.Features.Bases;
  using MediatR;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  public class CreateCatalogItemRequest : BaseRequest, IRequest<CreateCatalogItemResponse>
  {
    
  }
}
