using System.Collections.Generic;
using System.Linq;

namespace Journey.EQSFSW.V2002
{
    /// <summary>
    /// 地表水环境质量标准基本项目水质类别
    /// </summary>
    public class BasicItemsGrade
    {
        /// <summary>
        /// 根据PH值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByPHValue(double value)
        {
            if (value < 0) return null;
            if (value >= 6 && value <= 9) return (1, "Ⅰ");
            else return (6, "劣Ⅴ");
        }

        /// <summary>
        /// 根据溶解氧值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByDOValue(double value)
        {
            if (value < 0) return null;
            if (value >= 7.5) return (1, "Ⅰ");
            if (value >= 6) return (2, "Ⅱ");
            if (value >= 5) return (3, "Ⅲ");
            if (value >= 3) return (4, "Ⅳ");
            if (value >= 2) return (5, "Ⅴ");
            if (value < 2 && value > 0) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据高锰酸盐指数值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByCODMnValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 2) return (1, "Ⅰ");
            if (value <= 4) return (2, "Ⅱ");
            if (value <= 6) return (3, "Ⅲ");
            if (value <= 10) return (4, "Ⅳ");
            if (value <= 15) return (5, "Ⅴ");
            if (value > 15) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据化学需氧量值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByCODValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 15) return (1, "Ⅰ");
            if (value <= 20) return (3, "Ⅲ");
            if (value <= 30) return (4, "Ⅳ");
            if (value <= 40) return (5, "Ⅴ");
            if (value > 40) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据五日生化需氧量值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByBOD5Value(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 3) return (1, "Ⅰ");
            if (value <= 4) return (3, "Ⅲ");
            if (value <= 6) return (4, "Ⅳ");
            if (value <= 10) return (5, "Ⅴ");
            if (value > 10) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据氨氮值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByNH3NValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.15) return (1, "Ⅰ");
            if (value <= 0.5) return (2, "Ⅱ");
            if (value <= 1) return (3, "Ⅲ");
            if (value <= 1.5) return (4, "Ⅳ");
            if (value <= 2) return (5, "Ⅴ");
            if (value > 2) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 根据总磷值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type">1.河流;2.湖库</param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        /// <exception cref="System.Exception"></exception>
        public static (int, string)? GetGradeByTPValue(double value, int type = 1)
        {
            if (value < 0) return null;
            if (type == 1)
            {
                if (value > 0 && value <= 0.02) return (1, "Ⅰ");
                if (value <= 0.1) return (2, "Ⅱ");
                if (value <= 0.2) return (3, "Ⅲ");
                if (value <= 0.3) return (4, "Ⅳ");
                if (value <= 0.4) return (5, "Ⅴ");
                if (value > 0.4) return (6, "劣Ⅴ");
                return null;
            }
            else if (type == 2)
            {
                if (value > 0 && value <= 0.01) return (1, "Ⅰ");
                if (value <= 0.025) return (2, "Ⅱ");
                if (value <= 0.05) return (3, "Ⅲ");
                if (value <= 0.1) return (4, "Ⅳ");
                if (value <= 0.2) return (5, "Ⅴ");
                if (value > 0.2) return (6, "劣Ⅴ");
                return null;
            }
            else throw new System.Exception("type参数错误");
        }


        /// <summary>
        /// 根据总氮值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByTNValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.2) return (1, "Ⅰ");
            if (value <= 0.5) return (2, "Ⅱ");
            if (value <= 1) return (3, "Ⅲ");
            if (value <= 1.5) return (4, "Ⅳ");
            if (value <= 2) return (5, "Ⅴ");
            if (value > 2) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 根据铜值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByCuValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.01) return (1, "Ⅰ");
            if (value <= 1) return (2, "Ⅱ");
            if (value > 1) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据锌值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByZnValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.05) return (1, "Ⅰ");
            if (value <= 1) return (2, "Ⅱ");
            if (value <= 2) return (4, "Ⅳ");
            if (value > 2) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据氟化物值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByFValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 1) return (1, "Ⅰ");
            if (value <= 1.5) return (4, "Ⅳ");
            if (value > 1.5) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据硒值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeBySeValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.01) return (1, "Ⅰ");
            if (value <= 0.02) return (4, "Ⅳ");
            if (value > 0.02) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据砷值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByAsValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.05) return (1, "Ⅰ");
            if (value <= 0.1) return (4, "Ⅳ");
            if (value > 0.1) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据汞值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByHgValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.00005) return (1, "Ⅰ");
            if (value <= 0.0001) return (3, "Ⅲ");
            if (value <= 0.001) return (4, "Ⅳ");
            if (value > 0.001) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据镉值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByCdValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.001) return (1, "Ⅰ");
            if (value <= 0.005) return (2, "Ⅱ");
            if (value <= 0.01) return (5, "Ⅴ");
            if (value > 0.01) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据铬(六价)值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByCr6Value(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.01) return (1, "Ⅰ");
            if (value <= 0.05) return (2, "Ⅱ");
            if (value <= 0.1) return (5, "Ⅴ");
            if (value > 0.1) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据铅值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByPbValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.01) return (1, "Ⅰ");
            if (value <= 0.05) return (3, "Ⅲ");
            if (value <= 0.1) return (5, "Ⅴ");
            if (value > 0.1) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据氰化物值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByCNValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.005) return (1, "Ⅰ");
            if (value <= 0.05) return (2, "Ⅱ");
            if (value <= 0.2) return (3, "Ⅲ");
            if (value > 0.2) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据挥发酚值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByVolatilePhenolValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.002) return (1, "Ⅰ");
            if (value <= 0.005) return (3, "Ⅲ");
            if (value <= 0.01) return (4, "Ⅳ");
            if (value <= 0.1) return (5, "Ⅴ");
            if (value > 0.1) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据石油类值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByOilValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.05) return (1, "Ⅰ");
            if (value <= 0.5) return (4, "Ⅳ");
            if (value <= 1) return (5, "Ⅴ");
            if (value > 1) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据阴离子表面活性剂值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByAnionicSurfactantValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.2) return (1, "Ⅰ");
            if (value <= 0.3) return (4, "Ⅳ");
            if (value > 0.3) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据硫化物值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByS2Value(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 0.05) return (1, "Ⅰ");
            if (value <= 0.1) return (2, "Ⅱ");
            if (value <= 0.2) return (3, "Ⅲ");
            if (value <= 0.5) return (4, "Ⅳ");
            if (value <= 1) return (5, "Ⅴ");
            if (value > 1) return (6, "劣Ⅴ");
            return null;
        }


        /// <summary>
        /// 根据粪大肠菌群值获取类别
        /// </summary>
        /// <param name="value"></param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetGradeByFCValue(double value)
        {
            if (value < 0) return null;
            if (value > 0 && value <= 200) return (1, "Ⅰ");
            if (value <= 2000) return (2, "Ⅱ");
            if (value <= 10000) return (3, "Ⅲ");
            if (value <= 20000) return (4, "Ⅳ");
            if (value <= 40000) return (5, "Ⅴ");
            if (value > 40000) return (6, "劣Ⅴ");
            return null;
        }

        /// <summary>
        /// 获取整体水质类别
        /// </summary>
        /// <param name="data"></param>
        /// <param name="tpType">1.河流;2.湖库</param>
        /// <param name="analysisTN">总氮是否参与计算</param>
        /// <param name="analysisFC">粪大肠是否参与计算</param>
        /// <returns>(1,Ⅰ)(数字类别,文字类别)</returns>
        public static (int, string)? GetWaterGrade(EQSFSW_BasicItem data, int tpType = 1, bool analysisTN = false, bool analysisFC = false)
        {
            List<int> grades = new List<int>();
            if (data.PH != null)
            {
                var tmp = GetGradeByPHValue(data.PH.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.DO != null)
            {
                var tmp = GetGradeByDOValue(data.DO.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.CODMn != null)
            {
                var tmp = GetGradeByCODMnValue(data.CODMn.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.COD != null)
            {
                var tmp = GetGradeByCODValue(data.COD.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.BOD5 != null)
            {
                var tmp = GetGradeByBOD5Value(data.BOD5.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.NH3N != null)
            {
                var tmp = GetGradeByNH3NValue(data.NH3N.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.TP != null)
            {
                var tmp = GetGradeByTPValue(data.TP.Value, tpType);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (analysisTN && data.TN != null)
            {
                var tmp = GetGradeByTNValue(data.TN.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.Cu != null)
            {
                var tmp = GetGradeByCuValue(data.Cu.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.Zn != null)
            {
                var tmp = GetGradeByZnValue(data.Zn.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.F != null)
            {
                var tmp = GetGradeByFValue(data.F.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.Se != null)
            {
                var tmp = GetGradeBySeValue(data.Se.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.As != null)
            {
                var tmp = GetGradeByAsValue(data.As.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.Hg != null)
            {
                var tmp = GetGradeByHgValue(data.Hg.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.Cd != null)
            {
                var tmp = GetGradeByCdValue(data.Cd.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.Cr6 != null)
            {
                var tmp = GetGradeByCr6Value(data.Cr6.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.Pb != null)
            {
                var tmp = GetGradeByPbValue(data.Pb.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.CN != null)
            {
                var tmp = GetGradeByCNValue(data.CN.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.VolatilePhenol != null)
            {
                var tmp = GetGradeByVolatilePhenolValue(data.VolatilePhenol.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.Oil != null)
            {
                var tmp = GetGradeByOilValue(data.Oil.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.AnionicSurfactant != null)
            {
                var tmp = GetGradeByAnionicSurfactantValue(data.AnionicSurfactant.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (data.S2 != null)
            {
                var tmp = GetGradeByS2Value(data.S2.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (analysisFC && data.FC != null)
            {
                var tmp = GetGradeByFCValue(data.FC.Value);
                if (tmp != null) grades.Add(tmp.Value.Item1);
            }
            if (grades.Count > 0)
            {
                var max = grades.Max();
                var gradeStr = GradeIntToStr(max) ?? "";
                return (max, gradeStr);
            }
            else return null;
        }


        /// <summary>
        /// 水质类别转换为文本
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static string? GradeIntToStr(int grade)
        {
            return grade switch
            {
                1 => "Ⅰ",
                2 => "Ⅱ",
                3 => "Ⅲ",
                4 => "Ⅳ",
                5 => "Ⅴ",
                6 => "劣Ⅴ",
                _ => null,
            };
        }

        /// <summary>
        /// 水质类别转换为数字
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public int? GradeStrToInt(string grade)
        {
            return grade switch
            {
                "Ⅰ" => 1,
                "Ⅱ" => 2,
                "Ⅲ" => 3,
                "Ⅳ" => 4,
                "Ⅴ" => 5,
                "劣Ⅴ" => 6,
                _ => null,
            };
        }
    }
}
