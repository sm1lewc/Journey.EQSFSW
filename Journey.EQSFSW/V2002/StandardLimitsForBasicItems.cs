using System.Collections.Generic;

namespace Journey.EQSFSW.V2002
{
    /// <summary>
    /// 地表水环境质量标准基本项目标准限值
    /// </summary>
    public class StandardLimitsForBasicItems
    {
        #region PH

        /// <summary>
        /// PH标准限值
        /// (min,max)
        /// </summary>
        /// <returns></returns>
        public static (double, double) PHLimit()
        {
            return (6, 9);
        }

        /// <summary>
        /// 根据PH值获取水质
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int GetGradeByPHValue(double value)
        {
            if (value >= 6 && value <= 9) return 1;
            else return 6;
        }

        #endregion

        #region 溶解氧 DO
        /// <summary>
        /// 溶解氧标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> DOLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 7.5},
                new StandardLimit(){Grade = 2,Limit = 6},
                new StandardLimit(){Grade = 3,Limit = 5},
                new StandardLimit(){Grade = 4,Limit = 3},
                new StandardLimit(){Grade = 5,Limit = 2},
            };
        }

        /// <summary>
        /// 根据水质类别获取溶解氧标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetDOLimitByGrade(int grade)
        {
            return grade switch
            {
                1 => 7.5,
                2 => 6,
                3 => 5,
                4 => 3,
                5 => 2,
                _ => null,
            };
        }

        /// <summary>
        /// 根据溶解氧值获取水质
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int? GetGradeByDOValue(double value)
        {
            if (value >= 7.5) return 1;
            if (value >= 6) return 2;
            if (value >= 5) return 3;
            if (value >= 3) return 4;
            if (value >= 2) return 5;
            if (value < 2 && value > 0) return 6;
            return null;
        }

        #endregion

        #region 高锰酸盐指数 CODMn

        /// <summary>
        /// 高锰酸盐指数标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> CODMnLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 2},
                new StandardLimit(){Grade = 2,Limit = 4},
                new StandardLimit(){Grade = 3,Limit = 6},
                new StandardLimit(){Grade = 4,Limit = 10},
                new StandardLimit(){Grade = 5,Limit = 15},
            };
        }

        /// <summary>
        /// 根据水质类别获取高锰酸盐指数标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetCODMnLimitByGrade(int grade)
        {
            return grade switch
            {
                1 => 2,
                2 => 4,
                3 => 6,
                4 => 10,
                5 => 15,
                _ => null,
            };
        }

        /// <summary>
        /// 根据高锰酸盐指数值获取水质
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int? GetGradeByCODMnValue(double value)
        {
            if (value > 0 && value <= 2) return 1;
            if (value <= 4) return 2;
            if (value <= 6) return 3;
            if (value <= 10) return 4;
            if (value <= 15) return 5;
            if (value > 15) return 6;
            return null;
        }

        #endregion

        #region 化学需氧量 COD

        /// <summary>
        /// 化学需氧量标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> CODLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 15},
                new StandardLimit(){Grade = 2,Limit = 15},
                new StandardLimit(){Grade = 3,Limit = 20},
                new StandardLimit(){Grade = 4,Limit = 30},
                new StandardLimit(){Grade = 5,Limit = 40},
            };
        }

        /// <summary>
        /// 根据水质类别获取化学需氧量标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetCODLimitByGrade(int grade)
        {
            return grade switch
            {
                1 => 15,
                2 => 15,
                3 => 20,
                4 => 30,
                5 => 40,
                _ => null,
            };
        }

        /// <summary>
        /// 根据化学需氧量值获取水质
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int? GetGradeByCODValue(double value)
        {
            if (value > 0 && value <= 15) return 1;
            if (value <= 20) return 3;
            if (value <= 30) return 4;
            if (value <= 40) return 5;
            if (value > 40) return 6;
            return null;
        }

        #endregion

        #region 五日生化需氧量 BOD5

        /// <summary>
        /// 五日生化需氧量标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> BOD5Limit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 3},
                new StandardLimit(){Grade = 2,Limit = 3},
                new StandardLimit(){Grade = 3,Limit = 4},
                new StandardLimit(){Grade = 4,Limit = 6},
                new StandardLimit(){Grade = 5,Limit = 10},
            };
        }

        /// <summary>
        /// 根据水质类别获取五日生化需氧量标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetBOD5LimitByGrade(int grade)
        {
            return grade switch
            {
                1 => 3,
                2 => 3,
                3 => 4,
                4 => 6,
                5 => 10,
                _ => null,
            };
        }

        /// <summary>
        /// 根据五日生化需氧量值获取水质
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int? GetGradeByBOD5Value(double value)
        {
            if (value > 0 && value <= 3) return 1;
            if (value <= 4) return 3;
            if (value <= 6) return 4;
            if (value <= 10) return 5;
            if (value > 10) return 6;
            return null;
        }

        #endregion

        #region

        /// <summary>
        /// 氨氮标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> NH3NLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.15},
                new StandardLimit(){Grade = 2,Limit = 0.5},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 1.5},
                new StandardLimit(){Grade = 5,Limit = 2},
            };
        }

        /// <summary>
        /// 根据水质类别获取氨氮标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double? GetNH3NLimitByGrade(int grade)
        {
            return grade switch
            {
                1 => 0.15,
                2 => 0.5,
                3 => 1,
                4 => 1.5,
                5 => 2,
                _ => null,
            };
        }

        /// <summary>
        /// 根据氨氮值获取水质
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int? GetGradeByNH3NValue(double value)
        {
            if (value > 0 && value <= 0.15) return 1;
            if (value <= 0.5) return 2;
            if (value <= 1) return 3;
            if (value <= 1.5) return 4;
            if (value <= 2) return 5;
            if (value > 2) return 6;
            return null;
        }

        #endregion

        #region 总磷 TP

        /// <summary>
        /// 总磷标准限值
        /// </summary>
        /// <param name="type">1.河流;2.湖库</param>
        /// <returns></returns>
        public static List<StandardLimit> TPLimit(int type = 1)
        {
            if (type == 1) return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.02},
                new StandardLimit(){Grade = 2,Limit = 0.1},
                new StandardLimit(){Grade = 3,Limit = 0.2},
                new StandardLimit(){Grade = 4,Limit = 0.3},
                new StandardLimit(){Grade = 5,Limit = 0.4},
            };
            else if (type == 2) return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01},
                new StandardLimit(){Grade = 2,Limit = 0.025},
                new StandardLimit(){Grade = 3,Limit = 0.05},
                new StandardLimit(){Grade = 4,Limit = 0.1},
                new StandardLimit(){Grade = 5,Limit = 0.2},
            };
            else throw new System.Exception("type参数错误");
        }

        /// <summary>
        /// 根据水质类别获取总磷标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public static double? GetTPLimitByGrade(int grade, int type = 1)
        {
            if (type == 1) return grade switch
            {
                1 => 0.02,
                2 => 0.1,
                3 => 0.2,
                4 => 0.3,
                5 => 0.4,
                _ => null,
            };
            else if (type == 2) return grade switch
            {
                1 => 0.01,
                2 => 0.025,
                3 => 0.05,
                4 => 0.1,
                5 => 0.2,
                _ => null,
            };
            else throw new System.Exception("type参数错误");
        }

        /// <summary>
        /// 根据总磷值获取水质
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public static int? GetGradeByTPValue(double value, int type = 1)
        {
            if (type == 1)
            {
                if (value > 0 && value <= 0.02) return 1;
                if (value <= 0.1) return 2;
                if (value <= 0.2) return 3;
                if (value <= 0.3) return 4;
                if (value <= 0.4) return 5;
                if (value > 0.4) return 6;
                return null;
            }
            else if (type == 2)
            {
                if (value > 0 && value <= 0.01) return 1;
                if (value <= 0.025) return 2;
                if (value <= 0.05) return 3;
                if (value <= 0.1) return 4;
                if (value <= 0.2) return 5;
                if (value > 0.2) return 6;
                return null;
            }
            else throw new System.Exception("type参数错误");
        }

        #endregion

        /// <summary>
        /// 总氮标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> TNLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.2},
                new StandardLimit(){Grade = 2,Limit = 0.5},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 1.5},
                new StandardLimit(){Grade = 5,Limit = 2},
            };
        }

        /// <summary>
        /// 铜标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> CuLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01},
                new StandardLimit(){Grade = 2,Limit = 1},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 1},
                new StandardLimit(){Grade = 5,Limit = 1},
            };
        }

        /// <summary>
        /// 锌标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> ZnLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.05},
                new StandardLimit(){Grade = 2,Limit = 1},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 2},
                new StandardLimit(){Grade = 5,Limit = 2},
            };
        }

        /// <summary>
        /// 氟化物标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> FLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 1},
                new StandardLimit(){Grade = 2,Limit = 1},
                new StandardLimit(){Grade = 3,Limit = 1},
                new StandardLimit(){Grade = 4,Limit = 1.5},
                new StandardLimit(){Grade = 5,Limit = 1.5},
            };
        }

        /// <summary>
        /// 硒标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> SeLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01},
                new StandardLimit(){Grade = 2,Limit = 0.01},
                new StandardLimit(){Grade = 3,Limit = 0.01},
                new StandardLimit(){Grade = 4,Limit = 0.02},
                new StandardLimit(){Grade = 5,Limit = 0.02},
            };
        }

        /// <summary>
        /// 砷标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> AsLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.05},
                new StandardLimit(){Grade = 2,Limit = 0.05},
                new StandardLimit(){Grade = 3,Limit = 0.05},
                new StandardLimit(){Grade = 4,Limit = 0.1},
                new StandardLimit(){Grade = 5,Limit = 0.1},
            };
        }

        /// <summary>
        /// 汞标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> HgLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.00005},
                new StandardLimit(){Grade = 2,Limit = 0.00005},
                new StandardLimit(){Grade = 3,Limit = 0.0001},
                new StandardLimit(){Grade = 4,Limit = 0.001},
                new StandardLimit(){Grade = 5,Limit = 0.001},
            };
        }

        /// <summary>
        /// 镉标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> CdLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.001},
                new StandardLimit(){Grade = 2,Limit = 0.005},
                new StandardLimit(){Grade = 3,Limit = 0.005},
                new StandardLimit(){Grade = 4,Limit = 0.005},
                new StandardLimit(){Grade = 5,Limit = 0.01},
            };
        }

        /// <summary>
        /// 铬(六价)标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> Cr6Limit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01},
                new StandardLimit(){Grade = 2,Limit = 0.05},
                new StandardLimit(){Grade = 3,Limit = 0.05},
                new StandardLimit(){Grade = 4,Limit = 0.05},
                new StandardLimit(){Grade = 5,Limit = 0.1},
            };
        }

        /// <summary>
        /// 铅标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> PbLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.01},
                new StandardLimit(){Grade = 2,Limit = 0.01},
                new StandardLimit(){Grade = 3,Limit = 0.05},
                new StandardLimit(){Grade = 4,Limit = 0.05},
                new StandardLimit(){Grade = 5,Limit = 0.1},
            };
        }

        /// <summary>
        /// 氰化物标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> CNLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.005},
                new StandardLimit(){Grade = 2,Limit = 0.05},
                new StandardLimit(){Grade = 3,Limit = 0.2},
                new StandardLimit(){Grade = 4,Limit = 0.2},
                new StandardLimit(){Grade = 5,Limit = 0.2},
            };
        }

        /// <summary>
        /// 挥发酚标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> VolatilePhenolLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.002},
                new StandardLimit(){Grade = 2,Limit = 0.002},
                new StandardLimit(){Grade = 3,Limit = 0.005},
                new StandardLimit(){Grade = 4,Limit = 0.01},
                new StandardLimit(){Grade = 5,Limit = 0.1},
            };
        }

        /// <summary>
        /// 石油类标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> OilLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.05},
                new StandardLimit(){Grade = 2,Limit = 0.05},
                new StandardLimit(){Grade = 3,Limit = 0.05},
                new StandardLimit(){Grade = 4,Limit = 0.5},
                new StandardLimit(){Grade = 5,Limit = 1},
            };
        }

        /// <summary>
        /// 阴离子表面活性剂标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> AnionicSurfactantLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.2},
                new StandardLimit(){Grade = 2,Limit = 0.2},
                new StandardLimit(){Grade = 3,Limit = 0.2},
                new StandardLimit(){Grade = 4,Limit = 0.3},
                new StandardLimit(){Grade = 5,Limit = 0.3},
            };
        }

        /// <summary>
        /// 硫化物标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> S2Limit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 0.05},
                new StandardLimit(){Grade = 2,Limit = 0.1},
                new StandardLimit(){Grade = 3,Limit = 0.2},
                new StandardLimit(){Grade = 4,Limit = 0.5},
                new StandardLimit(){Grade = 5,Limit = 1},
            };
        }

        /// <summary>
        /// 粪大肠菌群标准限值
        /// </summary>
        /// <returns></returns>
        public static List<StandardLimit> FCLimit()
        {
            return new List<StandardLimit>()
            {
                new StandardLimit(){Grade = 1,Limit = 200},
                new StandardLimit(){Grade = 2,Limit = 2000},
                new StandardLimit(){Grade = 3,Limit = 10000},
                new StandardLimit(){Grade = 4,Limit = 20000},
                new StandardLimit(){Grade = 5,Limit = 40000},
            };
        }
    }

    public class StandardLimit
    {
        public int Grade { get; set; }
        public double Limit { get; set; }
    }
}
