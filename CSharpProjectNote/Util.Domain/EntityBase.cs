using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Domain
{
    /// <summary>
    /// 领域实体
    /// </summary>
    public abstract class EntityBase<TKey>
    {
        /// <summary>
        /// 初始化领域实体
        /// </summary>
        /// <param name="id"></param>
        protected EntityBase(TKey id)
        {
            Id = id;
        }
        /// <summary>
        /// 标识
        /// </summary>
        [Required]
        public TKey Id { get; private set; }
    }
}
