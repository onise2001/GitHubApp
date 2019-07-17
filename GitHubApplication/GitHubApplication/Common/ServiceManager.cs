using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace GitHubApplication.Common
{
    public sealed class ServiceManager
    {
        public IUnityContainer Container { get; } = new UnityContainer();


        private static ServiceManager _instance = new ServiceManager();

        public static ServiceManager Instance
        {
            get { return _instance; }
        }


        static ServiceManager()
        {

        }


        private ServiceManager()
        {

        }
    }
}
