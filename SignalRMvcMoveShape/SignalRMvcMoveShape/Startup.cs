using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRMvcMoveShape
{
    //[assembly: OwinStartup(typeof(MoveShapeDemo.Startup))]
    [assembly: OwinStartup(typeof(SignalRMvcMoveShape.Startup))]
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}