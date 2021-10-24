using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIMAN.Web.Shared
{
    public partial class MainLayout
    {
        [Inject] NavigationManager UriHelper { get; set; }
        private string TuKhoaTimKiem;

        public void TimKiemSanPham()
        {
            if (!string.IsNullOrEmpty(TuKhoaTimKiem))
            {
                UriHelper.NavigateTo($"tim-kiem/{TuKhoaTimKiem}");
                TuKhoaTimKiem = null;
            }
           
        }
    }
}
