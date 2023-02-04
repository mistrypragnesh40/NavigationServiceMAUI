using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationServiceMAUI.Services
{
    public class NavigationService : INavigationService
    {
        public T GetPageViewModel<T>() where T : new()
        {
            var pageDetails = Shell.Current.CurrentItem.CurrentItem.Stack.Where(f => f != null && f.BindingContext.GetType() == typeof(T)).FirstOrDefault();
            if(pageDetails != null)
            {
                return (T)pageDetails.BindingContext;
            }
            return default(T);
        }

        public Task NavigateToAsync(string route, IDictionary<string, object> parameters)
        {
            if (parameters != null)
                return Shell.Current.GoToAsync(route, parameters);
            else
                return Shell.Current.GoToAsync(route);

        }
    }
}
