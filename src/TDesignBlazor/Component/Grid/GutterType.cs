using OneOf;




namespace TDesign.Component
{

    /// <summary>
    /// 响应式
    /// </summary>
    public class ResponsiveSetting
    {
        public OneOf<int, ResponsiveTinySetting> Xs { get; set; }
        public OneOf<int, ResponsiveTinySetting> Sm { get; set; }
        public OneOf<int, ResponsiveTinySetting> Md { get; set; }
        public OneOf<int, ResponsiveTinySetting> Lg { get; set; }
        public OneOf<int, ResponsiveTinySetting> Xl { get; set; }
        public OneOf<int, ResponsiveTinySetting> Xxl { get; set; }
    }

    /// <summary>
    /// 响应式微调
    /// </summary>
    public class ResponsiveTinySetting
    {
        /// <summary>
        /// 栅格左侧的间隔格数，间隔内不可以有栅格
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// 栅格占位格数，为 0 时相当于 display: none
        /// </summary>
        public int Span { get; set; }
        /// <summary>
        /// 栅格顺序，flex 布局模式下有效
        /// </summary>
        public int Order { get; set; }
        /// <summary>
        /// 栅格向左移动格数
        /// </summary>
        public int Pull { get; set; }
        /// <summary>
        /// 栅格向右移动格数
        /// </summary>
        public int Push { get; set; }
    }

}
