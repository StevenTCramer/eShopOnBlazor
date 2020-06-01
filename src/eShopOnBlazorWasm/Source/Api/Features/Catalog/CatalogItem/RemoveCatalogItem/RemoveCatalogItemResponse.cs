﻿namespace eShopOnBlazorWasm.Features.Catalog
{
  using eShopOnBlazorWasm.Features.Bases;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  public class RemoveCatalogItemResponse : BaseResponse
  {
    public RemoveCatalogItemResponse(Guid aRequestId)
    {
      RequestId = aRequestId;
    }
  }
}
