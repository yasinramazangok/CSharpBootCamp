﻿using MYYouTubeBootCampModule501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYYouTubeBootCampModule501.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task CreateProductAsync(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetByProductIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
