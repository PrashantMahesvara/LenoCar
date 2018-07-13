using System.Collections.Generic;
using System.Web.Mvc;

namespace LenoCar.ViewModels.Authentication
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
    }
}