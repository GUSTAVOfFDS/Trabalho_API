﻿using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace Tabalho_so2.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}
