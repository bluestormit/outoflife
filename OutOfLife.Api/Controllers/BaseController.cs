using System;
using Microsoft.AspNetCore.Mvc;

namespace OutOfLife.Api.Controllers
{
    public abstract class BaseController<TService> : ControllerBase, IDisposable
        where TService : IDisposable
    {
        protected TService service;

        public BaseController(TService Service) =>
            this.service = Service;

        public void Dispose()
        {
            this.service.Dispose();
        }
    }
}