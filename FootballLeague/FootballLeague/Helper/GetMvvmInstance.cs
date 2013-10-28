using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Helper
{
    public class GetMvvmInstance
    {
        public static T GetInstance<T>(string keyval) where T : class
        {

            if (!SimpleIoc.Default.IsRegistered<T>(keyval))
            {

                SimpleIoc.Default.Register<T>(() => { return (T)typeof(T).GetConstructor(new Type[] { }).Invoke(new object[] { }); }, keyval);
            }

            return SimpleIoc.Default.GetInstance<T>(keyval);
        }
    }
}
