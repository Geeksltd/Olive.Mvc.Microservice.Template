namespace Website
{
    using Controllers;
    using Olive;
    using Olive.Entities;
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class Navigation : Olive.Mvc.Microservices.Navigation
    {
        public override void Define()
        {
            Add<BaseController>("MenuItem/SubItem", "fas fa-folder");

        }
    }
}
