﻿using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProducts
{
    public class CreateProductProfile : Profile
    {
        public CreateProductProfile() 
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<Product, CreateProductResult>().ReverseMap();
        }
    }
}
