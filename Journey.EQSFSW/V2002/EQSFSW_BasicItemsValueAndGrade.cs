namespace Journey.EQSFSW.V2002
{
    /// <summary>
    /// 地表水环境质量标准24项基本项目值、类别、整体水质类别
    /// </summary>
    public class EQSFSW_BasicItemsValueAndGrade : EQSFSW_BasicItem
    {
        /// <summary>
        /// PH值类别
        /// </summary>
        public int? PHGrade { get; set; }
        /// <summary>
        /// PH值类别文本
        /// </summary>
        public string? PHGradeText { get; set; }
        /// <summary>
        /// 溶解氧类别
        /// </summary>
        public int? DOGrade { get; set; }
        /// <summary>
        /// 溶解氧类别文本
        /// </summary>
        public string? DOGradeText { get; set; }
        /// <summary>
        /// 高锰酸盐指数类别
        /// </summary>
        public int? CODMnGrade { get; set; }
        /// <summary>
        /// 高锰酸盐指数类别文本
        /// </summary>
        public string? CODMnGradeText { get; set; }
        /// <summary>
        /// 化学需氧量类别
        /// </summary>
        public int? CODGrade { get; set; }
        /// <summary>
        /// 化学需氧量类别文本
        /// </summary>
        public string? CODGradeText { get; set; }
        /// <summary>
        /// 五日生化需氧量类别
        /// </summary>
        public int? BOD5Grade { get; set; }
        /// <summary>
        /// 五日生化需氧量类别文本
        /// </summary>
        public string? BOD5GradeText { get; set; }
        /// <summary>
        /// 氨氮类别
        /// </summary>
        public int? NH3NGrade { get; set; }
        /// <summary>
        /// 氨氮类别文本
        /// </summary>
        public string? NH3NGradeText { get; set; }
        /// <summary>
        /// 总磷类别
        /// </summary>
        public int? TPGrade { get; set; }
        /// <summary>
        /// 总磷类别文本
        /// </summary>
        public string? TPGradeText { get; set; }
        /// <summary>
        /// 总氮类别
        /// </summary>
        public int? TNGrade { get; set; }
        /// <summary>
        /// 总氮类别文本
        /// </summary>
        public string? TNGradeText { get; set; }
        /// <summary>
        /// 铜类别
        /// </summary>
        public int? CuGrade { get; set; }
        /// <summary>
        /// 铜类别文本
        /// </summary>
        public string? CuGradeText { get; set; }
        /// <summary>
        /// 锌类别
        /// </summary>
        public int? ZnGrade { get; set; }
        /// <summary>
        /// 锌类别文本
        /// </summary>
        public string? ZnGradeText { get; set; }
        /// <summary>
        /// 氟化物类别
        /// </summary>
        public int? FGrade { get; set; }
        /// <summary>
        /// 氟化物类别文本
        /// </summary>
        public string? FGradeText { get; set; }
        /// <summary>
        /// 硒类别
        /// </summary>
        public int? SeGrade { get; set; }
        /// <summary>
        /// 硒类别文本
        /// </summary>
        public string? SeGradeText { get; set; }
        /// <summary>
        /// 砷类别 
        /// </summary>
        public int? AsGrade { get; set; }
        /// <summary>
        /// 砷类别文本
        /// </summary>
        public string? AsGradeText { get; set; }
        /// <summary>
        /// 汞类别
        /// </summary>
        public int? HgGrade { get; set; }
        /// <summary>
        /// 汞类别文本
        /// </summary>
        public string? HgGradeText { get; set; }
        /// <summary>
        /// 镉类别
        /// </summary>
        public int? CdGrade { get; set; }
        /// <summary>
        /// 镉类别文本
        /// </summary>
        public string? CdGradeText { get; set; }
        /// <summary>
        /// 六价铬类别
        /// </summary>
        public int? Cr6Grade { get; set; }
        /// <summary>
        /// 六价铬类别文本
        /// </summary>
        public string? Cr6GradeText { get; set; }
        /// <summary>
        /// 铅类别
        /// </summary>
        public int? PbGrade { get; set; }
        /// <summary>
        /// 铅类别文本
        /// </summary>
        public string? PbGradeText { get; set; }
        /// <summary>
        /// 氰化物类别
        /// </summary>
        public int? CNGrade { get; set; }
        /// <summary>
        /// 氰化物类别文本
        /// </summary>
        public string? CNGradeText { get; set; }
        /// <summary>
        ///  挥发酚类别
        /// </summary>
        public int? VolatilePhenolGrade { get; set; }
        /// <summary>
        /// 挥发酚类别文本
        /// </summary>
        public string? VolatilePhenolGradeText { get; set; }
        /// <summary>
        /// 石油类类别
        /// </summary>
        public int? OilGrade { get; set; }
        /// <summary>
        /// 石油类类别文本
        /// </summary>
        public string? OilGradeText { get; set; }
        /// <summary>
        /// 阴离子表面活性剂类别
        /// </summary>
        public int? AnionicSurfactantGrade { get; set; }
        /// <summary>
        /// 阴离子表面活性剂类别文本
        /// </summary>
        public string? AnionicSurfactantGradeText { get; set; }
        /// <summary>
        /// 硫化物类别
        /// </summary>
        public int? S2Grade { get; set; }
        /// <summary>
        /// 硫化物类别文本
        /// </summary>
        public string? S2GradeText { get; set; }
        /// <summary>
        /// 粪大肠类别
        /// </summary>
        public int? FCGrade { get; set; }
        /// <summary>
        /// 粪大肠类别问题
        /// </summary>
        public string? FCGradeText { get; set; }
        /// <summary>
        /// 整体水质类别
        /// </summary>
        public int? WaterGrade { get; set; }
        /// <summary>
        /// 整体水质类别文本
        /// </summary>
        public string? WaterGradeText { get; set; }
    }
}
