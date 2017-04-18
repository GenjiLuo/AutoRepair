// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Location.cs
// 项目名称：买车网
// 创建时间：2016/8/29
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using AutoRepair.DAL;
using AutoRepair.Entity;
using System.Web;
using System.Linq;

namespace AutoRepair.BLL
{
    public partial class tb_LocationBLL : BaseBLL< tb_LocationBLL>

    {
        tb_LocationDataAccessLayer tb_Locationdal;
        public tb_LocationBLL()
        {
            tb_Locationdal = new tb_LocationDataAccessLayer();
        }

        public int Insert(tb_LocationEntity tb_LocationEntity)
        {
            return tb_Locationdal.Insert(tb_LocationEntity);            
        }

        public void Update(tb_LocationEntity tb_LocationEntity)
        {
            tb_Locationdal.Update(tb_LocationEntity);
        }

        public tb_LocationEntity GetAdminSingle(int locationId)
        {
           return tb_Locationdal.Get_tb_LocationEntity(locationId);
        }

        public IList<tb_LocationEntity> Gettb_LocationList()
        {
            IList<tb_LocationEntity> tb_LocationList = new List<tb_LocationEntity>();
            tb_LocationList=tb_Locationdal.Get_tb_LocationAll();
            return tb_LocationList;
        }

        /// <summary>
        /// 读取缓存所有数据
        /// </summary>
        /// <returns></returns>
        public IList<tb_LocationEntity> GetLocationListByCache()
        {
            string key = "LOCATION_LISTS";
            if (HttpContext.Current.Cache[key] != null)
            {
                return HttpContext.Current.Cache[key] as IList<tb_LocationEntity>;
            }
            else
            {
                IList<tb_LocationEntity> list = Gettb_LocationList();
                if (list == null)
                {
                    return new List<tb_LocationEntity>();
                }
                HttpContext.Current.Cache.Insert(key, list, null, DateTime.Now.AddHours(12), TimeSpan.Zero);
                return list;
            }
        }
        /// <summary>
        /// 读取缓存数据全部去除特别行政区
        /// </summary>
        /// <returns></returns>
        public IList<tb_LocationEntity> GetProvinceByCache()
        {
            IList<tb_LocationEntity> list = GetLocationListByCache();

            return list.Where(c => c.LocationParentId == 0 && c.LocationId < 700000).ToList();
        } 
        /// <summary>
        /// 获取全省
        /// </summary>
        /// <param name="locationid"></param>
        /// <returns></returns>
        public List<tb_LocationEntity> GetCityListCache(int locationid)
        {
            List<tb_LocationEntity> List = GetLocationListByCache() as List<tb_LocationEntity>;
            if (List != null)
            {
                List<tb_LocationEntity> temp = List.Where(c => c.LocationParentId == locationid).ToList<tb_LocationEntity>();
                return temp;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获取全市
        /// </summary>
        /// <param name="locationid"></param>
        /// <returns></returns>
        public List<tb_LocationEntity> GetCountyListCache(int locationid)
        {
            List<tb_LocationEntity> List = GetLocationListByCache() as List<tb_LocationEntity>;
            if (List != null)
            {
                List<tb_LocationEntity> temp = List.Where(c => c.LocationParentId == locationid).ToList<tb_LocationEntity>();
                return temp;
            }
            else
            {
                return null;
            }
        }
    }
}
