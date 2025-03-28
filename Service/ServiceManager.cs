﻿using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductoService> _productoService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _productoService = new Lazy<IProductoService>(() => new ProductoService(repositoryManager, logger, mapper));
        }
        public IProductoService ProductoService => _productoService.Value;
    }
}
