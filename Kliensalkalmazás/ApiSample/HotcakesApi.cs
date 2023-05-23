using System.Collections.Generic;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Catalog;

namespace ApiSample
{
    public class HotcakesApi
    {
        private readonly Api _api;

        public HotcakesApi(string url, string key)
        {
            _api = new Api(url, key);
        }

        public List<ProductDTO> GetProducts()
        {
            int pageNumber = 1;
            int pageSize = 100;
            ApiResponse<List<ProductDTO>> response = _api.ProductsFindAllPaged(pageNumber, pageSize);
            return response.Content;
        }
    }
}
