﻿using Ouroboros.IBLL;
using Ouroboros.IDAL;
using Ouroboros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouroboros.BLL
{
    public class SysUserActionService : BaseService<SysUserAction>, ISysUserActionService
    {
        #region 依赖注入
        ISysUserActionDao dao;
        /// <summary>
        /// 定义构造函数，接收autofac将数据仓储层的具体实现类的对象注入到此类中
        /// </summary>
        /// <param name="dao">具体实现类的对象</param>
        public SysUserActionService(ISysUserActionDao dao)
        {
            this.dao = dao;
            base.CurrentDao = dao;
            this.AddDisposableObject(this.CurrentDao);
        }
        #endregion
    }
}
