﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Dummy.HelperClasses;
using Dummy.FactoryClasses;
using Dummy.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Dummy.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Stock'.<br/><br/></summary>
	[Serializable]
	public partial class StockEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<PortofolioItemEntity> _portofolioItems;
		private EntityCollection<TransactionEntity> _transactions;
		private StockSectorEntity _stockSector;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static StockEntityStaticMetaData _staticMetaData = new StockEntityStaticMetaData();
		private static StockRelations _relationsFactory = new StockRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name StockSector</summary>
			public static readonly string StockSector = "StockSector";
			/// <summary>Member name PortofolioItems</summary>
			public static readonly string PortofolioItems = "PortofolioItems";
			/// <summary>Member name Transactions</summary>
			public static readonly string Transactions = "Transactions";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class StockEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public StockEntityStaticMetaData()
			{
				SetEntityCoreInfo("StockEntity", InheritanceHierarchyType.None, false, (int)Dummy.EntityType.StockEntity, typeof(StockEntity), typeof(StockEntityFactory), false);
				AddNavigatorMetaData<StockEntity, EntityCollection<PortofolioItemEntity>>("PortofolioItems", a => a._portofolioItems, (a, b) => a._portofolioItems = b, a => a.PortofolioItems, () => new StockRelations().PortofolioItemEntityUsingStockId, typeof(PortofolioItemEntity), (int)Dummy.EntityType.PortofolioItemEntity);
				AddNavigatorMetaData<StockEntity, EntityCollection<TransactionEntity>>("Transactions", a => a._transactions, (a, b) => a._transactions = b, a => a.Transactions, () => new StockRelations().TransactionEntityUsingStockId, typeof(TransactionEntity), (int)Dummy.EntityType.TransactionEntity);
				AddNavigatorMetaData<StockEntity, StockSectorEntity>("StockSector", "Stocks", (a, b) => a._stockSector = b, a => a._stockSector, (a, b) => a.StockSector = b, Dummy.RelationClasses.StaticStockRelations.StockSectorEntityUsingStockSectorIdStatic, ()=>new StockRelations().StockSectorEntityUsingStockSectorId, null, new int[] { (int)StockFieldIndex.StockSectorId }, null, true, (int)Dummy.EntityType.StockSectorEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static StockEntity()
		{
		}

		/// <summary> CTor</summary>
		public StockEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public StockEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this StockEntity</param>
		public StockEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="stockId">PK value for Stock which data should be fetched into this Stock object</param>
		public StockEntity(System.Int32 stockId) : this(stockId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="stockId">PK value for Stock which data should be fetched into this Stock object</param>
		/// <param name="validator">The custom validator object for this StockEntity</param>
		public StockEntity(System.Int32 stockId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.StockId = stockId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected StockEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PortofolioItem' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPortofolioItems() { return CreateRelationInfoForNavigator("PortofolioItems"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Transaction' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTransactions() { return CreateRelationInfoForNavigator("Transactions"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'StockSector' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStockSector() { return CreateRelationInfoForNavigator("StockSector"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this StockEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static StockRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PortofolioItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPortofolioItems { get { return _staticMetaData.GetPrefetchPathElement("PortofolioItems", CommonEntityBase.CreateEntityCollection<PortofolioItemEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Transaction' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTransactions { get { return _staticMetaData.GetPrefetchPathElement("Transactions", CommonEntityBase.CreateEntityCollection<TransactionEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'StockSector' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStockSector { get { return _staticMetaData.GetPrefetchPathElement("StockSector", CommonEntityBase.CreateEntityCollection<StockSectorEntity>()); } }

		/// <summary>The Code property of the Entity Stock<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Stock"."Code".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Code
		{
			get { return (System.String)GetValue((int)StockFieldIndex.Code, true); }
			set	{ SetValue((int)StockFieldIndex.Code, value); }
		}

		/// <summary>The CreatedDate property of the Entity Stock<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Stock"."CreatedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime2, 7, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreatedDate
		{
			get { return (System.DateTime)GetValue((int)StockFieldIndex.CreatedDate, true); }
			set	{ SetValue((int)StockFieldIndex.CreatedDate, value); }
		}

		/// <summary>The IsActive property of the Entity Stock<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Stock"."IsActive".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)StockFieldIndex.IsActive, true); }
			set	{ SetValue((int)StockFieldIndex.IsActive, value); }
		}

		/// <summary>The Name property of the Entity Stock<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Stock"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)StockFieldIndex.Name, true); }
			set	{ SetValue((int)StockFieldIndex.Name, value); }
		}

		/// <summary>The ReleaseDate property of the Entity Stock<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Stock"."ReleaseDate".<br/>Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ReleaseDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)StockFieldIndex.ReleaseDate, false); }
			set	{ SetValue((int)StockFieldIndex.ReleaseDate, value); }
		}

		/// <summary>The StockId property of the Entity Stock<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Stock"."StockId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 StockId
		{
			get { return (System.Int32)GetValue((int)StockFieldIndex.StockId, true); }
			set { SetValue((int)StockFieldIndex.StockId, value); }		}

		/// <summary>The StockSectorId property of the Entity Stock<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Stock"."StockSectorId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StockSectorId
		{
			get { return (System.Int32)GetValue((int)StockFieldIndex.StockSectorId, true); }
			set	{ SetValue((int)StockFieldIndex.StockSectorId, value); }
		}

		/// <summary>The TotalShare property of the Entity Stock<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Stock"."TotalShare".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int64> TotalShare
		{
			get { return (Nullable<System.Int64>)GetValue((int)StockFieldIndex.TotalShare, false); }
			set	{ SetValue((int)StockFieldIndex.TotalShare, value); }
		}

		/// <summary>The UpdateDate property of the Entity Stock<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Stock"."UpdateDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime2, 7, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime UpdateDate
		{
			get { return (System.DateTime)GetValue((int)StockFieldIndex.UpdateDate, true); }
			set	{ SetValue((int)StockFieldIndex.UpdateDate, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'PortofolioItemEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PortofolioItemEntity))]
		public virtual EntityCollection<PortofolioItemEntity> PortofolioItems { get { return GetOrCreateEntityCollection<PortofolioItemEntity, PortofolioItemEntityFactory>("Stock", true, false, ref _portofolioItems); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'TransactionEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TransactionEntity))]
		public virtual EntityCollection<TransactionEntity> Transactions { get { return GetOrCreateEntityCollection<TransactionEntity, TransactionEntityFactory>("Stock", true, false, ref _transactions); } }

		/// <summary>Gets / sets related entity of type 'StockSectorEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual StockSectorEntity StockSector
		{
			get { return _stockSector; }
			set { SetSingleRelatedEntityNavigator(value, "StockSector"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Dummy
{
	public enum StockFieldIndex
	{
		///<summary>Code. </summary>
		Code,
		///<summary>CreatedDate. </summary>
		CreatedDate,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>Name. </summary>
		Name,
		///<summary>ReleaseDate. </summary>
		ReleaseDate,
		///<summary>StockId. </summary>
		StockId,
		///<summary>StockSectorId. </summary>
		StockSectorId,
		///<summary>TotalShare. </summary>
		TotalShare,
		///<summary>UpdateDate. </summary>
		UpdateDate,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Dummy.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Stock. </summary>
	public partial class StockRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between StockEntity and PortofolioItemEntity over the 1:n relation they have, using the relation between the fields: Stock.StockId - PortofolioItem.StockId</summary>
		public virtual IEntityRelation PortofolioItemEntityUsingStockId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "PortofolioItems", true, new[] { StockFields.StockId, PortofolioItemFields.StockId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between StockEntity and TransactionEntity over the 1:n relation they have, using the relation between the fields: Stock.StockId - Transaction.StockId</summary>
		public virtual IEntityRelation TransactionEntityUsingStockId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Transactions", true, new[] { StockFields.StockId, TransactionFields.StockId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between StockEntity and StockSectorEntity over the m:1 relation they have, using the relation between the fields: Stock.StockSectorId - StockSector.StockSectorId</summary>
		public virtual IEntityRelation StockSectorEntityUsingStockSectorId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "StockSector", false, new[] { StockSectorFields.StockSectorId, StockFields.StockSectorId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticStockRelations
	{
		internal static readonly IEntityRelation PortofolioItemEntityUsingStockIdStatic = new StockRelations().PortofolioItemEntityUsingStockId;
		internal static readonly IEntityRelation TransactionEntityUsingStockIdStatic = new StockRelations().TransactionEntityUsingStockId;
		internal static readonly IEntityRelation StockSectorEntityUsingStockSectorIdStatic = new StockRelations().StockSectorEntityUsingStockSectorId;

		/// <summary>CTor</summary>
		static StaticStockRelations() { }
	}
}
