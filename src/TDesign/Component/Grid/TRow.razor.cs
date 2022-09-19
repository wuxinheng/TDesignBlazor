using Microsoft.AspNetCore.Components;
using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TDesign.Core.Base;
using System;


namespace TDesign.Component
{
    using ResponsiveBlend = OneOf.OneOf<int, System.Collections.Generic.IEnumerable<TDesign.Component.ResponsiveSetting>>;
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
