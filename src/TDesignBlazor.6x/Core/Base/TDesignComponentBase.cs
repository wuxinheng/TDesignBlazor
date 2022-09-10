using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDesignBlazor._6x.Core.Base
{
    public class TDesignComponentBase : ComponentBase, ITDesignComponentBase
    {

        /// <summary>
        /// 标签类容
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        /// <summary>
        /// 点击委托
        /// </summary>
        [Parameter]
        public Action<object> Click { get; set; }
        /// <summary>
        /// 点击执行
        /// </summary>
        /// <param name="obj"></param>
        public void OnClick(object obj)
        {
            if (Click != null)
            {
                Click.Invoke(obj);
            }
        }

        /// <summary>
        /// 全局配置上下文
        /// </summary>
        public TContext Context { get; set; }
    }
}
