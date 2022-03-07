using Business.Concrete.Constans;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(','); //Metni ayırmasını istediğin yerden "Split(',')" ayırarak array'in içerisine atar.
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>(); //ASP.NET içerisinden gelen bir yapı!
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles) //Rollerini gez.
            {
                if (roleClaims.Contains(role))
                {
                    return; //Claim içerisinde ilgili role var ise return et ve methodu çalıştır.
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
