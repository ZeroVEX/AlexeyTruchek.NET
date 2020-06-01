using AutoMapper;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace BLL.Services
{
    public class StandartMapper : IModelMapper
    {
        public TModel Map<T, TModel>(T item)
        {
            Mapper mapper =
                new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<T, TModel>()));

            return mapper.Map<T, TModel>(item);
        }
    }
}