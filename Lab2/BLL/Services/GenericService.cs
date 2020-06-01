using AutoMapper;
using BLL.Interfaces;
using BLL.Validators;
using DAL;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public abstract class GenericService<T, TModel> : IService<T>
        where TModel : class, IEntity
    {
        private readonly IRepository<TModel> _repository;
        private readonly IModelMapper _mapper;
        private readonly IValidator<T> _validator;

        public GenericService()
		{
            _mapper = new StandartMapper();
            _repository = new Repository<TModel>(new MyDbContext());
            _validator = new GenericValidator<T>();
        }
        public void Add(T item)
        {
            _validator.Validate(item);
            TModel model = _mapper.Map<T, TModel>(item);
            _repository.Add(model);
        }

        public void Delete(int id)
        {
            TModel model = _repository.GetByID(id);
            _repository.Delete(model);
        }

        public IEnumerable<T> GetAll()
        {
            var collection = _repository.GetAll();
            return collection.Select(item => _mapper.Map<TModel, T>(item));
        }

        public T GetByID(int id)
        {
            TModel model = _repository.GetByID(id);
            return _mapper.Map<TModel, T>(model);
        }

        public void Update(T item)
        {
            _validator.Validate(item);
            TModel model = _mapper.Map<T, TModel>(item);
            _repository.Update(model);
        }
    }
}