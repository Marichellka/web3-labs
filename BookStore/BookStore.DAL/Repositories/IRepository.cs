﻿using System.Linq.Expressions;
using BookStore.DAL.Models;
using BookStore.DAL.Specifications;

namespace BookStore.DAL.Repositories;

public interface  IRepository<TModel> where TModel : BaseModel
{
    Task<List<TModel>> GetAll(ISpecification<TModel>? specification = null);

    Task<TModel?> GetById(int id);

    Task Add(TModel entity);

    Task Delete(TModel entity);

    Task Update(TModel entity);
}
