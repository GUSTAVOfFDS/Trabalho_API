using Tabalho_so2.Hypermedia.Abstract;
using System.Collections.Generic;

namespace Tabalho_so2.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
