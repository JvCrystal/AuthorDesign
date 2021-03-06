﻿using AuthorDesign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorDesign.IDAL
{
    public interface IPageActionRepository : IBaseRepository<PageAction>
    {
        /// <summary>
        /// 获取角色分页列表
        /// </summary>
        /// <param name="startNum">起始数字</param>
        /// <param name="pageSize">页长</param>
        /// <param name="isDesc">是否倒序排列</param>
        /// <param name="rowCount">总页数</param>
        /// <returns>角色分页列表</returns>
        IQueryable<PageAction> LoadPageList(int startNum, int pageSize, bool isDesc, out int rowCount);
    }

}
