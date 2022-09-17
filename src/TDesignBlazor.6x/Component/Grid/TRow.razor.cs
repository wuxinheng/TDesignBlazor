using Microsoft.AspNetCore.Components;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using OneOf;
using TDesignBlazor._6x.Core.Base;
using System;


namespace TDesignBlazor._6x.Component
{
    using ResponsiveBlend = OneOf.OneOf<int, System.Collections.Generic.IEnumerable<TDesignBlazor._6x.Component.ResponsiveSetting>>;
    public partial class TRow : TDesignComponentBase
    {

        [Parameter]
        public string Align { get; set; }
        [Parameter]
        public string Justify { get; set; }
        [Parameter]
        public string Tag { get; set; }
        [Parameter]
        public OneOf<int, int[], ResponsiveSetting, IEnumerable<ResponsiveSetting>, IEnumerable<ResponsiveBlend>> Gutter { get; set; }


        protected override void OnInitialized()
        {
            base.OnInitialized();

        }
    }
}
