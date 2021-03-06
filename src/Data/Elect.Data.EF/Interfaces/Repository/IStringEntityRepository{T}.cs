﻿#region	License
//--------------------------------------------------
// <License>
//     <Copyright> 2018 © Top Nguyen </Copyright>
//     <Url> http://topnguyen.net/ </Url>
//     <Author> Top </Author>
//     <Project> Elect </Project>
//     <File>
//         <Name> IStringEntityRepository_T_.cs </Name>
//         <Created> 24/03/2018 10:52:31 PM </Created>
//         <Key> d6b339f4-b697-454e-b8c6-1169f268e57f </Key>
//     </File>
//     <Summary>
//         IStringEntityRepository_T_.cs is a part of Elect
//     </Summary>
// <License>
//--------------------------------------------------
#endregion License

using Elect.Data.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Elect.Data.EF.Interfaces.Repository
{
    public interface IStringEntityRepository<T> : IBaseEntityRepository<T> where T : StringEntity, new()
    {
        /// <summary>
        ///     Update Entities
        /// </summary>
        /// <param name="predicate">Update Where by match condition of predicate</param>
        /// <param name="entityNewData">New Data</param>
        /// <param name="changedProperties">Specific properties changed</param>
        /// <returns></returns>
        /// <remarks>
        ///     <para>We will auto set LastUpdatedTime to <c>DateTimeOffset.UtcNow</c> if not set before</para>
        ///     <para>You can override the LastUpdatedTime by override StandardizeEntities in UnitOfWork/BaseEntityUnitOfWork</para>
        /// </remarks>
        void UpdateWhere(Expression<Func<T, bool>> predicate, T entityNewData, params Expression<Func<T, object>>[] changedProperties);

        /// <summary>
        ///     Update Entities
        /// </summary>
        /// <param name="predicate">Update Where by match condition of predicate</param>
        /// <param name="entityNewData">New Data</param>
        /// <param name="changedProperties">Specific properties changed</param>
        /// <returns></returns>
        /// <remarks>
        ///     <para>We will auto set LastUpdatedTime to <c>DateTimeOffset.UtcNow</c> if not set before</para>
        ///     <para>You can override the LastUpdatedTime by override StandardizeEntities in UnitOfWork/BaseEntityUnitOfWork</para>
        /// </remarks>
        void UpdateWhere(Expression<Func<T, bool>> predicate, T entityNewData, params string[] changedProperties);

        /// <summary>
        ///     Delete Where by list id
        /// </summary>
        /// <param name="ids">list id use for identity the entities</param>
        /// <param name="isPhysicalDelete"></param>
        /// <remarks>
        ///     <para>When isPhysicalDelete is <c>true</c>, it's mean auto include soft delete record in query/predicate</para>
        ///     <para>We will auto set DeletedTime to <c>DateTimeOffset.UtcNow</c> if not set before</para>
        ///     <para>You can override the DeletedTime by override StandardizeEntities in UnitOfWork/BaseEntityUnitOfWork</para>
        /// </remarks>
        void DeleteWhere(List<string> ids, bool isPhysicalDelete = false);
    }
}